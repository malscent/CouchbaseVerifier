using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;

namespace CouchbaseVerifier.Validators
{
    public class ClusteredTestValidator : ITestValidator
    {
        public string Name => "IsNodeClustered";

        public string Description => "Checks to see if the node is part of an active cluster or not";

        public string ExpectedValueType => ExpectedValues.Bool.ToString();

        public TestDefinition GetDefaultTestDefinition()
        {
            return new TestDefinition{
                Name = this.Name,
                ExpectedResult = false.ToString()
            };
        }

        public bool PerformValidation(ICouchbaseCache cache, TestDefinition definition)
        {
            var nodeResponse = cache.GetNodeResponse();
            if (nodeResponse?.Nodes == null) {
                return false;
            }
            var clusterMember = false;
            foreach (var n in nodeResponse.Nodes) {
                if (n.ThisNode && n.ClusterMembership == "active") {
                    clusterMember = true;
                    break;
                }
            }
            bool expected;
            if (!bool.TryParse(definition.ExpectedResult, out expected)) {
                throw new ArgumentException($"{definition.ExpectedResult} cannot be parsed as a boolean type.");
            }
            return clusterMember == expected;
        }
    }
}