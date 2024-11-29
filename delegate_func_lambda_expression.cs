using System;

namespace Delegates
{
    class Program
    {        
        static void Main(string[] args)
        {
            Func<double, double> PriceHandler = (double price) => price;
            double value = PriceHandler.Invoke(256.34);
            Console.WriteLine($"Product price value ${value} USD");
            Console.ReadKey();
        }                
    }
