using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;

namespace CouchbaseVerifier.Validators
{
    public enum ExpectedValues {
        Int, Bool, String
    }
    public class NodeCountValidator : ITestValidator
    {
        public string Name => "NodeCount";

        public string Description => "Validates the number of nodes in the cluster";

        public string ExpectedValueType => ExpectedValues.Int.ToString();

        public TestDefinition GetDefaultTestDefinition()
        {
            return new TestDefinition{
                Name = this.Name,
                ExpectedResult = "3"
            };
        }

        public TestResult PerformValidation(ICouchbaseCache cache, TestDefinition definition)
        {
            int expected = definition.ValidateAndReturnInt();

            var nodeResponse = cache.GetNodeResponse();
            if (nodeResponse?.Nodes == null) {
                return new TestResult {
                    Success = false,
                    Actual = "null"
                };
            }
            return new TestResult{
                Success = nodeResponse.Nodes.Count() == expected,
                Actual = nodeResponse.Nodes.Count().ToString()
            };
        }
    }
}