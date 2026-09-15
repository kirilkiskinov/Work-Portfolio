using System;

namespace _01._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                if (command.Contains("Add Stop"))
                {
                    string[] tokens = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

                    int index = int.Parse(tokens[1]);
                    string value = tokens[2];

                    if (index >= stops.IndexOf(stops) && index < stops.Length)
                    {
                        stops = stops.Insert(index, value);
                    }

                    Console.WriteLine(stops);
                }
                else if (command.Contains("Remove Stop"))
                {
                    string[] tokens = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if (startIndex >= stops.IndexOf(stops) && endIndex < stops.Length)
                    {
                        string substring = stops.Substring(startIndex, endIndex - startIndex + 1);

                        stops = stops.Remove(startIndex, substring.Length);
                    }

                    Console.WriteLine(stops);
                }
                else if (command.Contains("Switch"))
                {
                    string[] tokens = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

                    string oldString = tokens[1];
                    string newString = tokens[2];

                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);
                    }

                    Console.WriteLine(stops);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
