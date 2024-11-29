using System;

namespace Delegates
{
    class Program
    {
        public delegate T PrintHandler<T,U>(T param1, U param2);

        static void Main(string[] args)
        {
            PrintHandler<string, string> printHandler = GetDetails;
            PrintHandler<int, int> resultHandler = GetResult;

            printHandler.Invoke("James", "Bond");
            resultHandler.Invoke(100, 200);
            Console.ReadKey();
        }

        static string GetDetails(string firstName, string secondName)
        {
            string fullName = firstName + " " + secondName;
            Console.WriteLine($"Full Name is {fullName}");
            return fullName;
        }

        static int GetResult(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine($"Total Result Score : {result}");
            return result;
        }
    }
}
