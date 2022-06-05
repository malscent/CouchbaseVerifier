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

        public TestResult PerformValidation(ICouchbaseCache cache, TestDefinition definition)
        {
            bool expected = definition.ValidateAndReturnBool();

            var nodeResponse = cache.GetNodeResponse();
            if (nodeResponse?.Nodes == null) {
                return new TestResult {
                    Success = false,
                    Actual = "null"
                };
            }
            var clusterMember = false;
            foreach (var n in nodeResponse.Nodes) {
                if (n.ThisNode && n.ClusterMembership == "active") {
                    clusterMember = true;
                    break;
                }
            }
            return new TestResult {
                Success = clusterMember == expected,
                Actual = clusterMember.ToString()
            };
        }
    }
}