using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int wonBattles = 0;

            while (input != "End of battle")
            {
                int distance = int.Parse(input);

                if (energy - distance < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    return;
                }
                else
                {
                    energy -= distance;

                    wonBattles++;

                    if (wonBattles % 3 == 0)
                    {
                        energy += wonBattles;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
        }
    }
}
