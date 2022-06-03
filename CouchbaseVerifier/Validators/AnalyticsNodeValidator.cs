using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;

namespace CouchbaseVerifier.Validators
{
    public class AnalyticsNodeValidator : ITestValidator
    {
        public string Name => "AnalyticsNodeCount";

        public string Description => "Counts the number of nodes that have the cbas service";

        public string ExpectedValueType => ExpectedValues.Int.ToString();

        public TestDefinition GetDefaultTestDefinition()
        {
            return new TestDefinition {
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
            var count = 0;
            foreach (var node in nodeResponse.Nodes) {
                var containsKv = node.Services?.Contains("cbas") ?? false;
                if (containsKv)
                    count++;
            }
            return count == expected;
        }
    }
}