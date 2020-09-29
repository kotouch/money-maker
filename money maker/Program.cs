using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money_maker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amont to cnvert to coins:");
            string totalAsString =
            Console.ReadLine();
            double total =
            Convert.ToDouble(totalAsString);
            Console.WriteLine($"{total} is equal to ...");

            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = Math.Floor(total / goldValue);
            double remainder = total % goldValue;
            Console.WriteLine(goldCoins);
            Console.WriteLine(remainder);

            double silverCoins = Math.Floor(remainder / silverValue);
            remainder = remainder % silverValue;

            Console.WriteLine($"Gold coins:{goldCoins}");
            Console.WriteLine($"Silver coins:{silverCoins}");
            Console.WriteLine($"Bronze coins:{remainder}");
        }
    }
}
