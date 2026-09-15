using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] tokens = command.Split(":|:");

                if (tokens[0] == "InsertSpace")
                {
                    int index = int.Parse(tokens[1]);

                    input = input.Insert(index, " ");

                    Console.WriteLine(input);
                }
                else if (tokens[0] == "Reverse")
                {
                    string substring = tokens[1];

                    if (input.Contains(substring))
                    {
                        int startIndex = input.IndexOf(substring);

                        input = input.Remove(startIndex, substring.Length);

                        substring = String.Concat(substring.Reverse());

                        input += substring;

                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (tokens[0] == "ChangeAll")
                {
                    string substring = tokens[1];
                    string replacement = tokens[2];

                    input = input.Replace(substring, replacement);

                    Console.WriteLine(input);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
