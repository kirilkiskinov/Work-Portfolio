using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Shoot")
                {
                    int index = int.Parse(tokens[1]);
                    int power = int.Parse(tokens[2]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers[index] -= power;

                        if (numbers[index] <= 0)
                        {
                            numbers.RemoveAt(index);
                        }
                    }
                }
                else if (tokens[0] == "Add")
                {
                    int index = int.Parse(tokens[1]);
                    int value = int.Parse(tokens[2]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (tokens[0] == "Strike")
                {
                    int index = int.Parse(tokens[1]);
                    int radius = int.Parse(tokens[2]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        int start = index - radius;
                        int end = index + radius;
                                             
                        if (start >= 0 && end < numbers.Count)
                        {
                            numbers.RemoveRange(start, end - start + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                            command = Console.ReadLine();
                            continue;
                        }
                    }                    
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join('|', numbers));
        }
    }
}
