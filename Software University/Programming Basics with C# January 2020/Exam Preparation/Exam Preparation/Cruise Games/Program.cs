using System;

namespace Cruise_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int gamesCont = int.Parse(Console.ReadLine());

            double volleyballPoints = 0;
            int volleyballCounter = 0;

            double tennisPoints = 0;
            int tennisCounter = 0;

            double badmintonPoints = 0;
            int badmintonCounter = 0;

            for (int currentGame = 1; currentGame <= gamesCont; currentGame++)
            {
                string gameName = Console.ReadLine();
                double gamePoints = double.Parse(Console.ReadLine());

                if (gameName == "volleyball")
                {
                    gamePoints *= 1.07;
                    volleyballPoints += gamePoints;
                    volleyballCounter++;
                }
                else if (gameName == "tennis")
                {
                    gamePoints *= 1.05;
                    tennisPoints += gamePoints;
                    tennisCounter++;
                }
                else if (gameName == "badminton")
                {
                    gamePoints *= 1.02;
                    badmintonPoints += gamePoints;
                    badmintonCounter++;
                }
            }
            double volleyballAveragePoints = Math.Floor(volleyballPoints / volleyballCounter);
            double tennisAveragePoints = Math.Floor(tennisPoints / tennisCounter);
            double badmintonAveragePoints = Math.Floor(badmintonPoints / badmintonCounter);

            double sum = Math.Floor(volleyballPoints + tennisPoints + badmintonPoints);

            if (volleyballAveragePoints >= 75 && tennisAveragePoints >= 75 && badmintonAveragePoints >= 75)
            {
                Console.WriteLine($"Congratulations, {playerName}! You won the cruise games with {sum} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {playerName}, you lost. Your points are only {sum}.");
            }
        }
    }
}
