using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;
using CouchbaseVerifier.Validators;
using CouchbaseVerifierCLI.Models;
using Moq;
using Newtonsoft.Json;

namespace CouchbaseVerifier.Tests
{
    public class NodeCountValidatorTests
    {
        [Fact]
        public void ReturnsTrueIfNodeCountIsTwoAndExpectedIsTwo()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "2"
            };
            var validator = new NodeCountValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.True(result);
        }

        [Fact]
        public void ReturnsFalseIfNodeCountIsTwoAndExpectedIsOne()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "1"
            };
            var validator = new NodeCountValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.False(result);
        }

        [Fact]
        public void ReturnsFalseIfDataNodeCountIsTwoAndExpectedIsOne()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "1"
            };
            var validator = new DataNodeValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.False(result);
        }

        [Fact]
        public void ReturnsTrueIfDataNodeCountIsTwoAndExpectedIsTwo()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "2"
            };
            var validator = new DataNodeValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.True(result);
        }
        
        [Fact]
        public void ReturnsFalseIfQueryNodeCountIsOneAndExpectedIsTwo()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "2"
            };
            var validator = new QueryNodeValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.False(result);
        }

        [Fact]
        public void ReturnsTrueIfQueryNodeCountIsOneAndExpectedIsOne()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "1"
            };
            var validator = new QueryNodeValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.True(result);
        }

        [Fact]
        public void ReturnsFalseIfIndexNodeCountIsOneAndExpectedIsTwo()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "2"
            };
            var validator = new IndexNodeValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.False(result);
        }

        [Fact]
        public void ReturnsTrueIfIndexNodeCountIsOneAndExpectedIsOne()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "1"
            };
            var validator = new IndexNodeValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.True(result);
        }

        [Fact]
        public void ReturnsFalseIfSearchNodeCountIsOneAndExpectedIsTwo()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "2"
            };
            var validator = new SearchNodeValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.False(result);
        }

        [Fact]
        public void ReturnsTrueIfSearchNodeCountIsOneAndExpectedIsOne()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "1"
            };
            var validator = new SearchNodeValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.True(result);
        }        
    }
}