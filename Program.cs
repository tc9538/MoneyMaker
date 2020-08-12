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
            Console.WriteLine("Enter the amount of cents to be converted to coins");
            int coins = Convert.ToInt32(Console.ReadLine());
        }
    }
}
