using System;

namespace Delegates
{
    class Program
    {        
        static void Main(string[] args)
        {
            Func<double, double> PriceHandler = (double price) => {
                Console.WriteLine($"Product price value ${price} USD");
                return price;
            };
            PriceHandler.Invoke(256.34);
            Console.ReadKey();
        }                
    }
}
