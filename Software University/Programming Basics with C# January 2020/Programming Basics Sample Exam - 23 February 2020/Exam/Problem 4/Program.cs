using System;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPassengers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());
                       
            int passengersLeft = 0;

            for (int i = 1; i <= stops; i++)
            {
                int passengersOut = int.Parse(Console.ReadLine());
                int passengersIn = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {                    
                    passengersLeft = startingPassengers - passengersOut + passengersIn - 2;
                    startingPassengers = passengersLeft;
                }
                else
                {
                    passengersLeft = startingPassengers - passengersOut + passengersIn + 2;
                    startingPassengers = passengersLeft;
                }
            }

            Console.WriteLine($"The final number of passengers is : {passengersLeft}");

        }
    }
}
