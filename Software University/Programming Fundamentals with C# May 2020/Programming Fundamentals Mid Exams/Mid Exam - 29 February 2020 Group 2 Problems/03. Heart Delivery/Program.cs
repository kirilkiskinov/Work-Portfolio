using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split('@').Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            int currentIndex = 0;

            while (command != "Love!")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Jump")
                {
                    int jumpLength = int.Parse(tokens[1]);

                    currentIndex += jumpLength;

                    if (currentIndex < 0 || currentIndex >= numbers.Length)
                    {
                        currentIndex = 0;
                    }

                    if (numbers[currentIndex] == 0)
                    {
                        Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                    }
                    else
                    {
                        numbers[currentIndex] -= 2;

                        if (numbers[currentIndex] == 0)
                        {
                            Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                        }
                    }
                }

                command = Console.ReadLine();
            }

            int houseCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    houseCount++;
                }
            }

            Console.WriteLine($"Cupid's last position was {currentIndex}.");

            if (houseCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {houseCount} places.");
            }
        }
    }
}
