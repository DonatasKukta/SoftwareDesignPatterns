namespace Singleton.Logging
{
    using System;

    static class StaticLogger
    {
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
