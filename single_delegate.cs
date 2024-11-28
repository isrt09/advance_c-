using System;

namespace Delegates
{
    class Program
    {
        public delegate int CalculatetorHandler(int firstNumber, int secondNumber);
        static void Main(string[] args)
        {            
            CalculatetorHandler calculatetorHandler = Add;
            int result = calculatetorHandler.Invoke(30, 20);
            Console.WriteLine("Addition Result : "+result);
            Console.ReadKey();
        }

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
