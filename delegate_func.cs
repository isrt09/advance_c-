using System;

namespace Delegates
{
    class Program
    {        
        static void Main(string[] args)
        {
            Func<double, double> PriceHandler = GetPrice;
            PriceHandler(128.34);
            Console.ReadKey();
        }        

        static double GetPrice(double price)
        {
            Console.WriteLine($"Product price value ${price} USD");
            return price;
        }
    }
}
