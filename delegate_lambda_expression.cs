using System;

namespace Delegates
{
    class Program
    {
        public delegate int CalculatetorHandler(int firstNumber, int secondNumber);

        static void Main(string[] args)
        {
            // delegate with lambda expression
            CalculatetorHandler calculatetorHandler1 = (int firstNumber, int secondNumber) => firstNumber + secondNumber;
            CalculatetorHandler calculatetorHandler2 = (firstNumber, secondNumber) => firstNumber + secondNumber;

            int result = calculatetorHandler1(30, 20);
            int score  = calculatetorHandler2(70, 30);


            Console.WriteLine("Addition Result : "+result);
            Console.WriteLine("Addition Result : "+score);
            Console.ReadKey();
        }

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        
    }
}
