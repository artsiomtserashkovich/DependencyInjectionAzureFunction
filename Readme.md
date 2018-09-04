## Dependency Injection based on [Indigo.Functions](https://github.com/daulet/Indigo.Functions) and [ielcoro's issues answear](https://github.com/Azure/azure-webjobs-sdk/issues/1865#issuecomment-417958408) 
Use [Inject] attribute to inject all your dependencies in Azure Function declaration.

```cs
[FunctionName("Example")]
public static IActionResult Run(
    [HttpTrigger("GET")] HttpRequest request,
    [Inject] InjectService injectInstance)
{
    ...
} 
```

## 
