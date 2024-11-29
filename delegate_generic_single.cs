using System;

namespace Delegates
{
    class Program
    {
        public delegate T PrintHandler<T>(T param);

        static void Main(string[] args)
        {
            PrintHandler<string> printHandler = GetMessage;
            printHandler.Invoke("\"Less is More\"");
            Console.ReadKey();
        }

        static string GetMessage(string message)
        {
            Console.WriteLine($"My Message is {message}");
            return message;
        }
    }
}
