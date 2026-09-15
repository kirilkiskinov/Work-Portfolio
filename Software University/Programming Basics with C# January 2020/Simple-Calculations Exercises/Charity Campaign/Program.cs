using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            int cakesPrice = cakes * 45;
            double wafflesPrice = waffles * 5.80;
            double pancakesPrice = pancakes * 3.20;

            double totalPriceForOneDay = (cakesPrice + wafflesPrice + pancakesPrice) * people;

            double totalPrice = totalPriceForOneDay * days;

            double difference = totalPrice / 8;

            double result = totalPrice - totalPrice / 8;

            //double result = totalPrice - difference;

            Console.WriteLine($"{result:F2}");


        }
    }
}
