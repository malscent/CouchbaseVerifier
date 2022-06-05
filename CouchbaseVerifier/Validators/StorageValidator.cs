using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;

namespace CouchbaseVerifier.Validators
{
    public class StorageValidator : ITestValidator
    {
        public string Name => "DiskStorage";

        public string Description => "Validates that the cluster has the expected value or more storage available (in GB)";

        public string ExpectedValueType => ExpectedValues.Int.ToString();

        public TestDefinition GetDefaultTestDefinition()
        {
            return new TestDefinition {
                Name = this.Name,
                ExpectedResult = "50"
            };
        }

        private const long GIGABYTE_IN_BYTES = 1073741824;
        public TestResult PerformValidation(ICouchbaseCache cache, TestDefinition definition)
        {
            long expected = definition.ValidateAndReturnInt();
            long expectedInBytes = expected * GIGABYTE_IN_BYTES;
            var poolsResponse = cache.GetPoolsResponse();
            var totalStorage = poolsResponse?.StorageTotals?.Hdd?.Total;
            if (totalStorage == null) {
                return new TestResult {
                    Success = false,
                    Actual = "null"
                };
            }
            return new TestResult {
                Success = totalStorage >= expectedInBytes,
                Actual = Convert.ToInt32((totalStorage.GetValueOrDefault() / GIGABYTE_IN_BYTES)).ToString()
            };
        }
    }
}