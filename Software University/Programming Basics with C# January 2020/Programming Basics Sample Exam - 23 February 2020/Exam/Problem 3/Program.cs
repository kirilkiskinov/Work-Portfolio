using System;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiType = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int meals = int.Parse(Console.ReadLine());
            string delivery = Console.ReadLine();

            double price = 0;
            double deliveryPrice = 0;

            if (restaurant == "Sushi Zone")
            {
                if (sushiType == "sashimi")
                {
                    price = meals * 4.99;
                }
                else if (sushiType == "maki")
                {
                    price = meals * 5.29;
                }
                else if (sushiType == "uramaki")
                {
                    price = meals * 5.99;
                }
                else if (sushiType == "temaki")
                {
                    price = meals * 4.29;
                }
            }
            else if (restaurant == "Sushi Time")
            {
                if (sushiType == "sashimi")
                {
                    price = meals * 5.49;
                }
                else if (sushiType == "maki")
                {
                    price = meals * 4.69;
                }
                else if (sushiType == "uramaki")
                {
                    price = meals * 4.49;
                }
                else if (sushiType == "temaki")
                {
                    price = meals * 5.19;
                }
            }
            else if (restaurant == "Sushi Bar")
            {
                if (sushiType == "sashimi")
                {
                    price = meals * 5.25;
                }
                else if (sushiType == "maki")
                {
                    price = meals * 5.55;
                }
                else if (sushiType == "uramaki")
                {
                    price = meals * 6.25;
                }
                else if (sushiType == "temaki")
                {
                    price = meals * 4.75;
                }
            }
            else if (restaurant == "Asian Pub")
            {
                if (sushiType == "sashimi")
                {
                    price = meals * 4.50;
                }
                else if (sushiType == "maki")
                {
                    price = meals * 4.80;
                }
                else if (sushiType == "uramaki")
                {
                    price = meals * 5.50;
                }
                else if (sushiType == "temaki")
                {
                    price = meals * 5.50;
                }
            }
            else
            {
                Console.WriteLine($"{restaurant} is invalid restaurant!");
                return;
            }

            if (delivery == "Y")
            {
                deliveryPrice = price * 0.20;                
            }

            double totalPrice = deliveryPrice + price;

            Console.WriteLine($"Total price: {Math.Ceiling(totalPrice)} lv.");

        }
    }
}
