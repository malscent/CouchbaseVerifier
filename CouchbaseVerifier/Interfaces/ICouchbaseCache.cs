using CouchbaseVerifierCLI.Models;

namespace CouchbaseVerifier.Interfaces
{
    public interface ICouchbaseCache
    {
         public NodeResponse GetNodeResponse();
         public PoolsResponse GetPoolsResponse();
    }
}