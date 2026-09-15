using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> destinations = new List<string>();

            string pattern = @"(=|\/)(?<place>[A-Z][a-z]{2,})(\1)";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            int travelPoints = 0;

            foreach (Match match in matches)
            {
                var length = match.Groups["place"].Value.Length;

                destinations.Add(match.Groups["place"].Value);

                travelPoints += length;
            }

            if (destinations.Count == 0)
            {
                Console.WriteLine("Destinations:");
            }
            else
            {
                Console.WriteLine($"Destinations: {String.Join(", ", destinations)}");
            }
            
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
