using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;
using CouchbaseVerifier.Validators;
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
            Assert.True(result.Success);
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
            Assert.False(result.Success);
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
            Assert.False(result.Success);
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
            Assert.True(result.Success);
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
            Assert.False(result.Success);
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
            Assert.True(result.Success);
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
            Assert.False(result.Success);
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
            Assert.True(result.Success);
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
            Assert.False(result.Success);
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
            Assert.True(result.Success);
        }
        [Fact]
        public void ReturnsFalseIfAnalyticsNodeCountIsZeroAndExpectedIsTwo()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "2"
            };
            var validator = new AnalyticsNodeValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.False(result.Success);
        }

        [Fact]
        public void ReturnsTrueIfAnalyticsNodeCountIsZeroAndExpectedIsZero()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "0"
            };
            var validator = new AnalyticsNodeValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.True(result.Success);
        } 
        [Fact]
        public void ReturnsFalseIfBackupNodeCountIsZeroAndExpectedIsTwo()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "2"
            };
            var validator = new BackupNodeValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.False(result.Success);
        }

        [Fact]
        public void ReturnsTrueIfBackupNodeCountIsOneAndExpectedIsOne()
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
            Assert.True(result.Success);
        } 
        [Fact]
        public void ReturnsFalseIfEventingNodeCountIsZeroAndExpectedIsTwo()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "2"
            };
            var validator = new EventingNodeValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.False(result.Success);
        }

        [Fact]
        public void ReturnsTrueIfEventingNodeCountIsZeroAndExpectedIsZero()
        {
            var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
            var mockCache = new Mock<ICouchbaseCache>();
            mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
            var definition = new TestDefinition {
                Name = "",
                ExpectedResult = "0"
            };
            var validator = new EventingNodeValidator();
            var result = validator.PerformValidation(mockCache.Object, definition);
            Assert.True(result.Success);
        }                         
    }
}