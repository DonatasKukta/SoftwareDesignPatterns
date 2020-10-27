namespace Singleton.Services
{
    using Singleton.Logging;

    public class BarService
    {
        private ILogger _injectedLogger;
        public BarService(ILogger injectedLogger)
        {
            _injectedLogger = injectedLogger;
        }

        public void Bar1()
        {
            StaticLogger.Log("Bar with Static Logger");
        }

        public void Bar2()
        {
            SingletonLogger.GetInstance().Log("Bar with Singleton Logger");
        }

        public void Bar3()
        {
            _injectedLogger.Log("Bar with Injected Logger");
        }
    }
}
