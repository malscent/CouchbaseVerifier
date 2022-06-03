using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Models;
using CouchbaseVerifier.Validators;
using CouchbaseVerifierCLI.Models;
using Moq;
using Newtonsoft.Json;

namespace CouchbaseVerifier.Tests;

public class ClusteredTestValidatorTests
{
    [Fact]
    public void ReturnsTrueIfNodeIsMemberOfClusterAndExpectedIsTrue()
    {
        var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
        var mockCache = new Mock<ICouchbaseCache>();
        mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
        var definition = new TestDefinition {
            Name = "",
            ExpectedResult = "true"
        };
        var validator = new ClusteredTestValidator();
        var result = validator.PerformValidation(mockCache.Object, definition);
        Assert.True(result);
    }

    [Fact]
    public void ReturnsFalseIfNodeIsMemberOfClusterAndExpectedIsFalse()
    {
        var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/BasicNodeResponse.json"));
        var mockCache = new Mock<ICouchbaseCache>();
        mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
        var definition = new TestDefinition {
            Name = "",
            ExpectedResult = "false"
        };
        var validator = new ClusteredTestValidator();
        var result = validator.PerformValidation(mockCache.Object, definition);
        Assert.False(result);
    }

    [Fact]
    public void ReturnsTrueIfNodeIsNotMemberOfClusterAndExpectedIsFalse()
    {
        var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/NodeResponseNoClustering.json"));
        var mockCache = new Mock<ICouchbaseCache>();
        mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
        var definition = new TestDefinition {
            Name = "",
            ExpectedResult = "false"
        };
        var validator = new ClusteredTestValidator();
        var result = validator.PerformValidation(mockCache.Object, definition);
        Assert.True(result);
    }

    [Fact]
    public void ReturnsFalseIfNodeIsNotMemberOfClusterAndExpectedIsTrue()
    {
        var response = JsonConvert.DeserializeObject<NodeResponse>(File.ReadAllText("./test_data/NodeResponseNoClustering.json"));
        var mockCache = new Mock<ICouchbaseCache>();
        mockCache.Setup(t => t.GetNodeResponse()).Returns(response ?? new NodeResponse());
        var definition = new TestDefinition {
            Name = "",
            ExpectedResult = "true"
        };
        var validator = new ClusteredTestValidator();
        var result = validator.PerformValidation(mockCache.Object, definition);
        Assert.False(result);
    }
}