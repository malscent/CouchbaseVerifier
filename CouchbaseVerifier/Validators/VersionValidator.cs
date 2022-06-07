using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;

namespace CouchbaseVerifier.Validators
{
    public class VersionValidator : ITestValidator
    {
        public string Name => "VersionValidator";

        public string Description => "Verifies the version on each node matches the expected value";

        public string ExpectedValueType => ExpectedValues.String.ToString();

        public TestDefinition GetDefaultTestDefinition()
        {
            return new TestDefinition {
                Name = this.Name,
                ExpectedResult = "7.0.1"
            };
        }

        public TestResult PerformValidation(ICouchbaseCache cache, TestDefinition definition)
        {
            var nodeResponse = cache.GetNodeResponse();
            if (nodeResponse?.Nodes == null) {
                return new TestResult {
                    Success = false,
                    Actual = "null"
                };
            }
            bool match = true;
            string actual = string.Empty;
            foreach (var n in nodeResponse.Nodes) {
                if (string.IsNullOrEmpty(n.Version)) {
                    match = false;
                    actual = "null";
                    break;
                } else if (n.Version.StartsWith(definition.ExpectedResult)) {
                    actual = n.Version;
                }
            }
            return new TestResult{
                Success = match,
                Actual = actual
            };
        }
    }
}