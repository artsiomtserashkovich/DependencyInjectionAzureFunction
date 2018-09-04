using DependencyInjection.DependencySetup.Injection;
using DependencyInjection.Sample.InjectService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace DependencyInjection.Sample
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]
            HttpRequest req,
            ILogger log,
            [Inject] IInjectService injectInstance
        )
        {
            log.LogInformation($"String from Inject Service : {injectInstance.GetSomeText}");

            return new OkObjectResult($"String from Inject Service : {injectInstance.GetSomeText}");
        }
    }
}