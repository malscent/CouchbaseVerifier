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

        public bool PerformValidation(ICouchbaseCache cache, TestDefinition definition)
        {
            var nodeResponse = cache.GetNodeResponse();
            if (nodeResponse?.Nodes == null) {
                return false;
            }
            int expected;
            if (!int.TryParse(definition.ExpectedResult, out expected)) {
                throw new ArgumentException($"{definition.ExpectedResult} cannot be parsed as a integer type.");
            }
            return nodeResponse.Nodes.Count() == expected;
        }
    }
}