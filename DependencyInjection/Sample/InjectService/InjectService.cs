namespace DependencyInjection.Sample.InjectService
{
    internal class InjectService : IInjectService
    {
        public InjectService()
        {
            GetSomeText = "String from Inject Service";
        }

        public string GetSomeText { get; }
    }

    public interface IInjectService
    {
        string GetSomeText { get; }
    }
}
