# Deprecated
Microsoft provide own DI : https://docs.microsoft.com/en-us/azure/azure-functions/functions-dotnet-dependency-injection

## Dependency Injection based on [Indigo.Functions](https://github.com/daulet/Indigo.Functions) and [ielcoro's issues answear](https://github.com/Azure/azure-webjobs-sdk/issues/1865#issuecomment-417958408) 
Use [Inject] attribute to inject all your dependencies in Azure Function declaration.

```cs
[FunctionName("Example")]
public static IActionResult Run(
    [HttpTrigger("GET")] HttpRequest request,
    [Inject] IInjectService injectInstance)
{
    ...
} 
```

## Register your dependencies 

For register your dependencies edit [DependencyConfiguration](https://github.com/ArtemTereshkovich/DependencyInjectionAzureFunction/blob/master/DependencyInjection/DependencySetup/DependencyConfiguration.cs)

``` cs
namespace Dependency_Injection
{
    public class DependencyConfiguration : IDependencyConfiguration
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Register dependencies there : 
            services.AddSingleton<IInjectService,InjectService>();
        }
    }
}
```
