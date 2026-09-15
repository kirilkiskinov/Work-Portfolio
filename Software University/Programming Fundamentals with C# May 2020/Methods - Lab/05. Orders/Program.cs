//Write a method that calculates the total price of an order and prints it on the console. 
//The method should receive one of the following products: coffee, coke, water, snacks; 
//and a quantity of the product. The prices for a single piece of each product are: 
//•	coffee – 1.50
//•	water – 1.00
//•	coke – 1.40
//•	snacks – 2.00
//Print the result formatted to the second decimal place.

using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            OrderTotalCost(product, quantity);
        }

        static void OrderTotalCost(string item, int amount)
        {
            switch (item)
            {
                case "coffee": Console.WriteLine($"{amount * 1.50:F2}"); break;
                case "water": Console.WriteLine($"{amount * 1.00:F2}"); break;
                case "coke": Console.WriteLine($"{amount * 1.40:F2}"); break;
                case "snacks": Console.WriteLine($"{amount * 2.00:F2}"); break;
            }
        }

    }
}
