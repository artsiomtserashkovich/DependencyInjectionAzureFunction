using Dependency_Injection.Injection;
using Microsoft.Azure.WebJobs;

namespace Dependency_Injection.ConfigurationHost
{
    public static class DependencyInjectionWebJobsBuilderExtensions
    {
        public static IWebJobsBuilder AddDependencyInjection(this IWebJobsBuilder builder)
        {
            builder.AddExtension(new InjectWebJobsExtension());
            return builder;
        }
    }
}