using DependencyInjection.DependencySetup.Injection;
using DependencyInjection.Sample.InjectService;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.DependencySetup
{
    public class DependencyConfiguration : IDependencyConfiguration
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IInjectService, InjectService>();
        }
    }
}