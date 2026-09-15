using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string plantInformation = Console.ReadLine();

                string[] tokens = plantInformation.Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plant = tokens[0];

                int rarity = int.Parse(tokens[1]);

                if (plants.ContainsKey(plant))
                {
                    plants.Remove(plant);
                    plants.Add(plant, new List<double>());
                    plants[plant].Add(rarity);
                }
                else
                {
                    plants.Add(plant, new List<double>());
                    plants[plant].Add(rarity);
                }
            }

            string command = Console.ReadLine();

            List<double> numbersCount = new List<double>();

            while (command != "Exhibition")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command.Contains("Rate: "))
                {
                    string plant = tokens[1];
                    double rating = double.Parse(tokens[3]);

                    if (plants.ContainsKey(plant))
                    {
                        if (plants[plant].Count == 1)
                        {
                            plants[plant].Add(rating);
                            numbersCount.Add(rating);
                            
                        }
                        else
                        {
                            plants[plant][1] += rating;
                            numbersCount.Add(rating);
                        }
                    }

                }
                else if (command.Contains("Update: "))
                {
                    string plant = tokens[1];
                    double rarity = double.Parse(tokens[3]);

                    plants[plant][0] = rarity;
                }
                else if (command.Contains("Reset: "))
                {
                    string plant = tokens[1];

                    plants[plant][1] = 0;

                    numbersCount.Clear();

                }
                else
                {
                    Console.WriteLine("error");
                }

                command = Console.ReadLine();
            }

            double average = numbersCount.Average();

            plants = plants.OrderByDescending(x => x.Value[0]).
                ThenByDescending(x => average).
                ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine("Plants for the exhibition:");
            foreach (var pair in plants)
            {
                var rating = pair.Value[1] / 2;
                Console.WriteLine($"-- {pair.Key}; Rarity: {pair.Value[0]}; Rating: {rating}");
            }
        }
    }
}
