using CouchbaseVerifier.Models;

namespace CouchbaseVerifier.Interfaces
{
    public interface ITestValidator
    {
         public string Name { get; }
         public string Description { get; }
         public string ExpectedValueType { get; }

         public TestDefinition GetDefaultTestDefinition();

         public TestResult PerformValidation(ICouchbaseCache cache, TestDefinition definition);
    }
}