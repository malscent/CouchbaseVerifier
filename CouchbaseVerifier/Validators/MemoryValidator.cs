using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;

namespace CouchbaseVerifier.Validators
{
    public class MemoryValidator : ITestValidator
    {
        public string Name => "AvailableMemory";

        public string Description => "Validates that available memory in the cluster is greater than or equal to the expected value (in GB)";

        public string ExpectedValueType => ExpectedValues.Int.ToString();

        public TestDefinition GetDefaultTestDefinition()
        {
            return new TestDefinition{
                Name = this.Name,
                ExpectedResult = "3"
            };
        }
        private const long GIGABYTE_IN_BYTES = 1073741824;

        public TestResult PerformValidation(ICouchbaseCache cache, TestDefinition definition)
        {
            var expected = definition.ValidateAndReturnInt();
            long expectedInBytes = expected * GIGABYTE_IN_BYTES;
            var poolsResponse = cache.GetPoolsResponse();
            var totalRam = poolsResponse?.StorageTotals?.Ram?.Total;
            if (totalRam == null) {
                return new TestResult {
                    Success = false,
                    Actual = "null"
                };
            }
            return new TestResult{
                Success = totalRam >= expectedInBytes,
                Actual = (totalRam.GetValueOrDefault() / GIGABYTE_IN_BYTES).ToString()
            };
        }
    }
}