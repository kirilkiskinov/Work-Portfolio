using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentGrades.ContainsKey(name))
                {
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades.Add(name, new List<double>());
                    studentGrades[name].Add(grade);
                }
            }

            var averageResults = new Dictionary<string, double>();

            foreach (var pair in studentGrades)
            {
                averageResults.Add(pair.Key, pair.Value.Average());
            }

            averageResults = averageResults.Where(student => student.Value >= 4.50)
                                           .OrderByDescending(student => student.Value)
                                           .ToDictionary(k => k.Key, v => v.Value);

            foreach (var pair in averageResults)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
            }
        }
    }
}
