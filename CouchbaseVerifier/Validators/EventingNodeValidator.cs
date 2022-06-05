using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;

namespace CouchbaseVerifier.Validators
{
    public class EventingNodeValidator : ITestValidator
    {
        public string Name => "EventingNodeCount";

        public string Description => "Counts the number of nodes that have the eventing service";

        public string ExpectedValueType => ExpectedValues.Int.ToString();

        public TestDefinition GetDefaultTestDefinition()
        {
            return new TestDefinition {
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
            var count = 0;
            foreach (var node in nodeResponse.Nodes) {
                var containsKv = node.Services?.Contains("eventing") ?? false;
                if (containsKv)
                    count++;
            }
            return new TestResult {
                Success = count == expected,
                Actual = count.ToString()
            };
        }
    }
}