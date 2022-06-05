using System.Text;
using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;
using Newtonsoft.Json;

namespace CouchbaseVerifier.Services
{
    public class CouchbaseCache : ICouchbaseCache, ICouchbaseCacheManager
    {
        private static readonly HttpClient client = new HttpClient();
        private PoolsResponse _poolsResponse = new PoolsResponse();
        private NodeResponse _nodeResponse = new NodeResponse();
        private DateTime _lastCacheSet;
        public ICouchbaseCache GetCache()
        {
           return this;
        }

        public NodeResponse GetNodeResponse()
        {
            return _nodeResponse;
        }

        public PoolsResponse GetPoolsResponse()
        {
            return _poolsResponse;
        }

        public async Task<bool> SetCache(string host, string username, string password, int retries, int timeout)
        {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes($"{username}:{password}")));
            client.Timeout = new TimeSpan(0, 0, timeout);
            var count = 0;
            while (count < retries) {
                try {
                    count++;   
                    var poolsResponse = await client.GetAsync($"{host}/pools/default");
                    var nodeResponse = await client.GetAsync($"{host}/pools/nodes");
                    if (poolsResponse.StatusCode == System.Net.HttpStatusCode.OK && nodeResponse.StatusCode == System.Net.HttpStatusCode.OK) {
                        _nodeResponse = JsonConvert.DeserializeObject<NodeResponse>(await nodeResponse.Content.ReadAsStringAsync()) ?? new NodeResponse();
                        _poolsResponse = JsonConvert.DeserializeObject<PoolsResponse>(await poolsResponse.Content.ReadAsStringAsync()) ?? new PoolsResponse();
                        _lastCacheSet = DateTime.UtcNow;
                        return true;
                    }
                } catch (Exception e) when (e is TaskCanceledException || e is HttpRequestException) {
                    continue;
                }
            }
            return false;
        }
    }
}