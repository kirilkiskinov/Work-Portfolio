using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double priceForTicket = 0;

            if (ticketType == "Premiere")
            {
                priceForTicket = 12;
            }
            else if (ticketType == "Normal")
            {
                priceForTicket = 7.5;
            }
            else if (ticketType == "Discount")
            {
                priceForTicket = 5;
            }

            int peopleCount = rows * columns;
            double totalPrice = peopleCount * priceForTicket;

            Console.WriteLine($"{totalPrice:F2} leva");
        }
    }
}
