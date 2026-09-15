using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForSuevenirs = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());

            double gasNeeded = 420.0 / 100.0 * 7.0;

            double gasPrice = gasNeeded * 1.85;

            double moneyForFoodAndSouvenirs = (3 * moneyForFood) + (3 * moneyForSuevenirs);

            double firstStay = moneyForHotel * 0.90;
            double secondStay = moneyForHotel * 0.85;
            double thirdStay = moneyForHotel * 0.80;

            double moneyNeeded = gasPrice + moneyForFoodAndSouvenirs + firstStay + secondStay + thirdStay;

            Console.WriteLine($"Money needed: {moneyNeeded:F2}");
            
        }
    }
}
