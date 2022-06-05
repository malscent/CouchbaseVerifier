using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;
using CouchbaseVerifier.Validators;
using Moq;
using Newtonsoft.Json;

namespace CouchbaseVerifier.Tests
{
    public class MemoryValidatorTests
    {
        [Fact]
        public void ReturnsTrueIfExpectedValueLessThanTotalRamAvailable()
        {
            var response = JsonConvert.DeserializeObject<PoolsResponse>(File.ReadAllText("./test_data/BasicPoolsResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetPoolsResponse()).Returns(response ?? new PoolsResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "3"
            };
            var validator = new MemoryValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.True(result.Success);
        }

        [Fact]
        public void ReturnsFalseIfExpectedValueGreaterThanTotalRamAvailable()
        {
            var response = JsonConvert.DeserializeObject<PoolsResponse>(File.ReadAllText("./test_data/BasicPoolsResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetPoolsResponse()).Returns(response ?? new PoolsResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "5"
            };
            var validator = new MemoryValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.False(result.Success);
        }
    }
}