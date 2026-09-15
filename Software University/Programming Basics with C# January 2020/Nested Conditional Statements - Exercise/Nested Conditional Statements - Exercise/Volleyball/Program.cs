using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holiday = int.Parse(Console.ReadLine());
            int weekendsInHometown = int.Parse(Console.ReadLine());

            int weekendsInSofia = 48 - weekendsInHometown;

            double gamesInSofia = weekendsInSofia * 0.75;

            double gamesInHometown = weekendsInHometown;

            double holidayGamesInSofia = (holiday * 1.0 * 2) / 3; // * 1.0 in order to convert from int to double

            double totalGames = gamesInSofia + gamesInHometown + holidayGamesInSofia;
          
            if (yearType == "leap")
            {                
                Console.WriteLine($"{Math.Floor(totalGames * 1.15)}");   // 15 % more games 
            }
            else
            {
                Console.WriteLine($"{Math.Floor(totalGames)}");
            }
        }
    }
}
