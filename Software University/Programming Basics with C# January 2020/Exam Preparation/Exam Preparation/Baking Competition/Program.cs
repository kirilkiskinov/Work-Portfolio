using System;

namespace Baking_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int participants = int.Parse(Console.ReadLine());

            int cookiesCount = 0;
            int cakesCount = 0;
            int wafflesCount = 0;

            int cookiesCounter = 0;
            int cakesCounter = 0;
            int wafflesCounter = 0;
            
            for (int i = 1; i <= participants; i++)
            {
                string name = Console.ReadLine();
                string command = Console.ReadLine(); // "cookies", "cakes", "waffles"               

                while (command != "Stop baking!")
                {
                    int sweetsCooked = int.Parse(Console.ReadLine());                    

                    if (command == "cookies")
                    {
                        cookiesCount += sweetsCooked;
                        cookiesCounter += sweetsCooked;
                    }
                    else if (command == "cakes")
                    {
                        cakesCount += sweetsCooked;
                        cakesCounter += sweetsCooked;
                    }
                    else if (command == "waffles")
                    {
                        wafflesCount += sweetsCooked;
                        wafflesCounter += sweetsCooked;
                    }

                    command = Console.ReadLine(); // "cookies", "cakes", "waffles"                                                                                                                            
                }

                Console.WriteLine($"{name} baked {cookiesCount} cookies, {cakesCount} cakes and {wafflesCount} waffles.");
                cookiesCount = 0;
                cakesCount = 0;
                wafflesCount = 0;
            }

            int totalSweets = cookiesCounter + cakesCounter + wafflesCounter;
            double sumForCharity = (cookiesCounter * 1.50) + (cakesCounter * 7.80) + (wafflesCounter * 2.30);

            Console.WriteLine($"All bakery sold: {totalSweets}");
            Console.WriteLine($"Total sum for charity: {sumForCharity:F2} lv.");

        }
    }
}
