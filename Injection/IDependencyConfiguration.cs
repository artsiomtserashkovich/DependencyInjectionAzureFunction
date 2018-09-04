using Microsoft.Extensions.DependencyInjection;

namespace Dependency_Injection.Injection
{
    public interface IDependencyConfiguration
    {
        void ConfigureServices(IServiceCollection services);
    }
}