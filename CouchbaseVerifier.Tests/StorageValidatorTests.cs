using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;
using CouchbaseVerifier.Validators;
using Moq;
using Newtonsoft.Json;

namespace CouchbaseVerifier.Tests
{
    public class StorageValidatorTests
    {
        [Fact]
        public void ReturnsTrueIfExpectedValueLessThanTotalStorageAvailable()
        {
            var response = JsonConvert.DeserializeObject<PoolsResponse>(File.ReadAllText("./test_data/BasicPoolsResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetPoolsResponse()).Returns(response ?? new PoolsResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "50"
            };
            var validator = new StorageValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.True(result.Success);
        }

        [Fact]
        public void ReturnsFalseIfExpectedValueGreaterThanTotalStorageAvailable()
        {
            var response = JsonConvert.DeserializeObject<PoolsResponse>(File.ReadAllText("./test_data/BasicPoolsResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetPoolsResponse()).Returns(response ?? new PoolsResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "75"
            };
            var validator = new StorageValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.False(result.Success);
        }
    }
}