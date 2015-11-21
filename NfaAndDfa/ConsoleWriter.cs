using System;

namespace NfaAndDfa
{
    public class ConsoleWriter
    {
        public static string Failure(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            return Write(message);
        }

        public static string Success(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            return Write(message);
        }

        private static string Write(string message)
        {
            Console.WriteLine(message);
            Console.ResetColor();
            return message;
        }
    }
}