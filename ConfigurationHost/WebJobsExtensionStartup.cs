using Dependency_Injection.ConfigurationHost;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;

[assembly: WebJobsStartup(typeof(WebJobsExtensionStartup), "Azure Function Extension")]

namespace Dependency_Injection.ConfigurationHost
{
    public class WebJobsExtensionStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddDependencyInjection();
        }
    }
}