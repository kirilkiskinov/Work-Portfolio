using System;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new SortedDictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string name = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[0];
                string id = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[1];

                if (companies.ContainsKey(name))
                {
                    List<string> ids = companies[name];

                    if (ids.Contains(id))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        companies[name].Add(id);
                    }
                }
                else
                {
                    companies.Add(name, new List<string>());
                    companies[name].Add(id);
                }

                input = Console.ReadLine();
            }

            foreach (var pair in companies)
            {
                Console.WriteLine(pair.Key);

                foreach (var id in pair.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
