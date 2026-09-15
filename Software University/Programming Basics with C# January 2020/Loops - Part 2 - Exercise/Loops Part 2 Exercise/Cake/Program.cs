using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int cakeSize = width * length;

            string input = Console.ReadLine();

            int piecesSum = 0;

            while (input != "STOP")
            {
                int piecesTaken = int.Parse(input);

                piecesSum += piecesTaken;

                if (piecesSum >= cakeSize)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (piecesSum >= cakeSize)
            {
                Console.WriteLine($"No more cake left! You need {piecesSum - cakeSize} pieces more.");
            }

            if (input == "STOP")
            {
                Console.WriteLine($"{cakeSize - piecesSum} pieces are left.");
            }
        }
    }
}
