using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.DependencySetup.Injection
{
    public interface IDependencyConfiguration
    {
        void ConfigureServices(IServiceCollection services);
    }
}