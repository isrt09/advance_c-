using System;

namespace Delegates
{
    class Program
    {
        public delegate void PrintHandler(string info);

        static void Main(string[] args)
        {
            PrintHandler printHandler = Hello;
            printHandler += Farewell;
            printHandler("C#");
            Console.ReadKey();
        }

        static void Hello(string name)
        {
            Console.WriteLine("Welcome to "+name);
        }

        static void Farewell(string greeting)
        {
            Console.WriteLine("Goodbye " + greeting);
        }
    }
}
