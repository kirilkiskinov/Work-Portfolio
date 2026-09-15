using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerQuantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double finalPrice = 0;            

            if (flowerType == "Roses")
            {
                if (flowerQuantity > 80)
                {
                    finalPrice = (flowerQuantity * 5) * 0.9;
                }
                else
                {
                    finalPrice = flowerQuantity * 5;
                }
            }
            else if (flowerType == "Dahlias")
            {
                if (flowerQuantity > 90)
                {
                    finalPrice = (flowerQuantity * 3.80) * 0.85;
                }
                else
                {
                    finalPrice = flowerQuantity * 3.80;
                }
            }
            else if (flowerType == "Tulips")
            {
                if (flowerQuantity > 80)
                {
                    finalPrice = (flowerQuantity * 2.80) * 0.85;
                }
                else
                {
                    finalPrice = flowerQuantity * 2.80;
                }
            }
            else if (flowerType == "Narcissus")
            {
                if (flowerQuantity < 120)
                {
                    finalPrice = (flowerQuantity * 3) * 1.15;
                }
                else
                {
                    finalPrice = flowerQuantity * 3;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                if (flowerQuantity < 80)
                {
                    finalPrice = (flowerQuantity * 2.50) * 1.20;
                }
                else
                {
                    finalPrice = flowerQuantity * 2.50;
                }                
            }

            double moneyLeft = 0;

            if (finalPrice <= budget)
            {
                 moneyLeft = budget - finalPrice;

                Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flowerType} and {moneyLeft:F2} leva left.");
            }
            else if (finalPrice > budget)
            {
                 moneyLeft = finalPrice - budget;

                Console.WriteLine($"Not enough money, you need {moneyLeft:F2} leva more.");
            }
        }
    }
}
