using System;

namespace Darts_Tournment
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());

            int moves = 0;            

            while (startingPoints > 0)
            {
                moves++;
                string sector = Console.ReadLine();

                if (sector == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {moves} moves!");
                    return;
                }

                int points = int.Parse(Console.ReadLine());

                if (sector == "number section")
                {
                    startingPoints -= points;
                }
                else if (sector == "double ring")
                {
                    startingPoints = startingPoints - (points * 2);
                }
                else if (sector == "triple ring")
                {
                    startingPoints = startingPoints - (points * 3);
                }                
            }

            if (startingPoints == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {moves} moves!");
            }
            else if (startingPoints < 0)
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(startingPoints)}.");
            }
        }
    }
}

