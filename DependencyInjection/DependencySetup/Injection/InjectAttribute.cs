using System;
using Microsoft.Azure.WebJobs.Description;

namespace DependencyInjection.DependencySetup.Injection
{
    [AttributeUsage(AttributeTargets.Parameter)]
    [Binding]
    public class InjectAttribute : Attribute
    {
    }
}