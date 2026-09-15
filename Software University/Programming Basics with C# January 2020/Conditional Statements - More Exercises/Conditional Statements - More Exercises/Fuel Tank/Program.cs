using System;

namespace Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());

            if (fuel == "Diesel" && liters >= 25)
            {
                Console.WriteLine($"You have enough diesel.");
            }
            else if (fuel == "Diesel" && liters < 25)
            {
                Console.WriteLine($"Fill your tank with diesel!");
            }
            else if (fuel == "Gasoline" && liters >= 25)
            {
                Console.WriteLine($"You have enough gasoline.");
            }
            else if (fuel == "Gasoline" && liters < 25)
            {
                Console.WriteLine($"Fill your tank with gasoline!");
            }
            else if (fuel == "Gas" && liters >= 25)
            {
                Console.WriteLine($"You have enough gas.");
            }
            else if (fuel == "Gas" && liters < 25)
            {
                Console.WriteLine($"Fill your tank with gas!");
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
