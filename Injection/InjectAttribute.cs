using System;
using Microsoft.Azure.WebJobs.Description;

namespace Dependency_Injection.Injection
{
    [AttributeUsage(AttributeTargets.Parameter)]
    [Binding]
    public class InjectAttribute : Attribute
    {
    }
}