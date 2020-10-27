namespace Singleton.Logging
{
    using System;

    class InjectedLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
