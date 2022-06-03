using CommandDotNet;
using CouchbaseVerifierCLI.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using CouchbaseVerifier.Interfaces;
using CouchbaseVerifier.Services;
using CommandDotNet.IoC.MicrosoftDependencyInjection;
using CouchbaseVerifier.Validators;

namespace CouchbaseVerifierCLI
{
    class Program
    {
        static int Main(string[] args)
        {
            return new AppRunner<VerifierCLI>().UseMicrosoftDependencyInjection(
                    Host.CreateDefaultBuilder()
                        .ConfigureServices((_, services) => 
                            services.AddScoped<ICouchbaseCache, CouchbaseCache>()
                                    .AddScoped<ITestValidator, ClusteredTestValidator>()
                                    .AddScoped<ITestValidator, NodeCountValidator>()
                                    .AddScoped<ITestValidator, DataNodeValidator>()
                                    .AddScoped<ITestValidator, QueryNodeValidator>()
                                    .AddScoped<ITestValidator, IndexNodeValidator>()
                                    .AddScoped<ITestValidator, SearchNodeValidator>()
                                    .AddScoped<ITestValidator, BackupNodeValidator>()
                                    .AddScoped<ITestValidator, AnalyticsNodeValidator>()
                                    .AddScoped<ITestValidator, EventingNodeValidator>()
                                    .AddSingleton<VerifierCLI>())
                        .Build().Services)
            .Run(args);
        }
    }
}
