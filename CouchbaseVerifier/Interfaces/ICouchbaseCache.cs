using CouchbaseVerifier.Models;

namespace CouchbaseVerifier.Interfaces
{
    public interface ICouchbaseCache
    {
         public NodeResponse GetNodeResponse();
         public PoolsResponse GetPoolsResponse();
    }

    public interface ICouchbaseCacheManager
    {
        public Task<bool> SetCache(string host, string username, string password, int retries, int timeout);
        public ICouchbaseCache GetCache();
    }
}