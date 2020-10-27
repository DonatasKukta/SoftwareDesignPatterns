namespace Singleton.Logging
{
    using System;

    class SingletonLogger : ILogger
    {

        private static SingletonLogger _instance;
        private SingletonLogger() { }

        public static SingletonLogger GetInstance()
        {
            if(_instance == null)
            {
                return new SingletonLogger();
            }
                return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
