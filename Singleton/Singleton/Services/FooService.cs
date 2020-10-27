namespace Singleton.Services
{
    using Singleton.Logging;

    public class FooService
    {
        private ILogger _injectedLogger;
        public FooService(ILogger injectedLogger)
        {
            _injectedLogger = injectedLogger;
        }

        public void Foo1()
        {
            StaticLogger.Log("Foo with Static Logger");
        }

        public void Foo2()
        {
            SingletonLogger.GetInstance().Log("Foo with Singleton Logger");
        }

        public void Foo3()
        {
            _injectedLogger.Log("Foo with Injected Logger");
        }
    }
}
