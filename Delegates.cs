using System;

namespace WelcomeExtended.Others
{
    public class Delegates
    {
        public static void LogToConsole(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERROR]: {message}");
            Console.ResetColor();
        }

        public static void LogToLogger(string message)
        {
            var logger = Helpers.LoggerHelper.GetLogger("DelegateLogger");
            logger.LogError(message);
        }
    }
}
