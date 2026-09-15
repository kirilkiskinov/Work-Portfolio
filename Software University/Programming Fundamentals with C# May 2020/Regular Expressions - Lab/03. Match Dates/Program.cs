using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>[0-9]{2})([.\/-])(?<month>[A-Z][a-z]{2})(\1)(?<year>[0-9]{4})"; // This is because C# backreferences don’t count named capture groups for backreferences.

            string datesString = Console.ReadLine();           

            Regex regex = new Regex(pattern);

            var matches = regex.Matches(datesString);

            foreach (Match date in matches)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
