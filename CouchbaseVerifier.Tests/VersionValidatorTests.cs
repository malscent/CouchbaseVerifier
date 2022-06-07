using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;
using CouchbaseVerifier.Validators;
using Moq;
using Newtonsoft.Json;

namespace CouchbaseVerifier.Tests
{
    public class VersionValidatorTests
    {
        [Fact]
        public void ReturnsTrueIfVersionStringMatchesExpected()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "7.0.1"
            };
            var validator = new VersionValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.True(result.Success);
        }
        [Fact]
        public void ReturnsFalseIfVersionStringDoesNotMatchExpected()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "7.0.0"
            };
            var validator = new VersionValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.True(result.Success);
        }  
    }
}