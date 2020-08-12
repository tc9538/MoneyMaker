using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins: ");
            double amount = Math.Floor(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"{amount} is equal to ...");
            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = Math.Floor(amount / goldValue);
            double remainder = amount % goldValue;

            double silverCoins = Math.Floor(remainder / silverValue);
            remainder = remainder % silverValue;

            Console.WriteLine("Gold amount: " + goldCoins);
            Console.WriteLine("Silver amount: " + silverCoins);
            Console.WriteLine("Bronze amount: " + remainder);



        }
    }
}
