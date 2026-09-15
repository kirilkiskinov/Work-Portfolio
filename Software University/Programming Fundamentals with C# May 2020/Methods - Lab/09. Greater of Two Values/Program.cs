//Create a method GetMax() that returns the greater of two values (type int, char or string).

using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            GetMax(type, first, second);
        }

        static void GetMax(string type, string first, string second)
        {
            if (type == "int")
            {
                int a = int.Parse(first);
                int b = int.Parse(second);

                Console.WriteLine(Math.Max(a, b));
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(first);
                char secondChar = char.Parse(second);

                if (firstChar > secondChar)
                {
                    Console.WriteLine(firstChar);
                }
                else
                {
                    Console.WriteLine(secondChar);
                }

            }
            else if (type == "string")
            {
                int result = string.Compare(first, second);

                if (result == 0) // first == second returns 0
                {
                    Console.WriteLine(first);
                }
                else if (result == 1) // first > second returns 1
                {
                    Console.WriteLine(first);
                }
                else if (result == -1) // first < second returns -1
                {
                    Console.WriteLine(second);
                }
            }
        }

    }
}
