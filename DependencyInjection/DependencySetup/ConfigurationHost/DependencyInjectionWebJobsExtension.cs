using DependencyInjection.DependencySetup.Injection;
using Microsoft.Azure.WebJobs;

namespace DependencyInjection.DependencySetup.ConfigurationHost
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