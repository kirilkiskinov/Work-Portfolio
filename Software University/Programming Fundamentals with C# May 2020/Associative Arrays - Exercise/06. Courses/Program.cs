using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string courseName = input.Split(" : ")[0];
                string studentName = input.Split(" : ")[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }

                input = Console.ReadLine();
            }

            courses = courses.OrderByDescending(course => course.Value.Count)
                             .ToDictionary(k => k.Key, v => v.Value);

            foreach (var pair in courses)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count}");

                var sortedNames = pair.Value.OrderBy(name => name).ToList();

                //pair.Value.Sort();

                foreach (var name in sortedNames)
                {
                    Console.WriteLine($"-- {name}");
                }           
            }
        }
    }
}
