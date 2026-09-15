using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] tokens = input.Split();

                string productName = tokens[0];
                double price = double.Parse(tokens[1]);
                double quantity = double.Parse(tokens[2]);

                if (orders.ContainsKey(productName))
                {
                    orders[productName][1] += quantity;
                    orders[productName][0] = price;
                }
                else
                {
                    orders.Add(productName, new List<double>() { price, quantity });
                }
                ;
                input = Console.ReadLine();
            }

            foreach (var order in orders)
            {
                string productName = order.Key;

                double totalPrice = order.Value[0] * order.Value[1];

                Console.WriteLine($"{productName} -> {totalPrice:F2}");
            }          
        }
    }
}
