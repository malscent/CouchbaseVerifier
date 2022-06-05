using CouchbaseVerifier.Models;

namespace CouchbaseVerifier.Tests
{
    public class TestDefinitionTests
    {
        [Fact]
        public void ValidateAndReturnBoolReturnsBoolForFalseString()
        {
            var td = new TestDefinition {
                ExpectedResult = "false"
            };
            Assert.False(td.ValidateAndReturnBool());
        }
        [Fact]
        public void ValidateAndReturnBoolReturnsBoolForTrueString()
        {
            var td = new TestDefinition {
                ExpectedResult = "true"
            };
            Assert.True(td.ValidateAndReturnBool());
        }
        [Fact]
        public void ValidateAndReturnBoolThrowsOnBadData()
        {
            var td = new TestDefinition {
                ExpectedResult = "foobar"
            };
            Assert.Throws<ArgumentException>(() => td.ValidateAndReturnBool());
        }

        [Fact]
        public void ValidateAndReturnBoolThrowsOnIntegerData()
        {
            var td = new TestDefinition {
                ExpectedResult = "345"
            };
            Assert.Throws<ArgumentException>(() => td.ValidateAndReturnBool());
        }
        
        [Fact]
        public void ValidateAndReturnIntReturnsIntForIntString()
        {
            var td = new TestDefinition {
                ExpectedResult = "325"
            };
            Assert.True(td.ValidateAndReturnInt() == 325);
        }
        [Fact]
        public void ValidateAndReturnIntThrowsOnBadData()
        {
            var td = new TestDefinition {
                ExpectedResult = "foobar"
            };
            Assert.Throws<ArgumentException>(() => td.ValidateAndReturnInt());
        }

        [Fact]
        public void ValidateAndReturnBoolThrowsOnBadIntegerData()
        {
            var td = new TestDefinition {
                ExpectedResult = "345.6777"
            };
            Assert.Throws<ArgumentException>(() => td.ValidateAndReturnInt());
        }
    }
}