using System;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int singerPrice = int.Parse(Console.ReadLine());

            int envelope = 0;
            int totalEnvelope = 0;
            int guests = 0;

            string command = Console.ReadLine();

            while (command != "The restaurant is full")
            {
                int currentNumber = int.Parse(command);
                guests += currentNumber;

                if (currentNumber < 5)
                {
                    envelope = currentNumber * 100;
                }
                else
                {
                    envelope = currentNumber * 70;
                }

                totalEnvelope += envelope;                

                command = Console.ReadLine();
            }

            int sumLeft = totalEnvelope - singerPrice;

            if (sumLeft >= 0)
            {
                Console.WriteLine($"You have {guests} guests and {sumLeft} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {guests} guests and {totalEnvelope} leva income, but no singer.");
            }
        }
    }
}
