using System;
using Welcome.Model;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static string ToUserString(this User user)
        {
            return $"ID: {user.Id}, Name: {user.Names}, Role: {user.Role}, Age: {user.Age}";
        }
    }

    public static class LoggerHelper
    {
        public static ILogger GetLogger(string name)
        {
            return new ConsoleLogger(name);
        }
    }

    public interface ILogger
    {
        void LogError(string message);
    }

    public class ConsoleLogger : ILogger
    {
        private string _name;
        public ConsoleLogger(string name) => _name = name;
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{_name} ERROR]: {message}");
            Console.ResetColor();
        }
    }
}
