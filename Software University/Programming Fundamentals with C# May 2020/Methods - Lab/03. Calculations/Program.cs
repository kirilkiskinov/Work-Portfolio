//Write a program that receives a string on the first line (add, multiply, subtract, divide) 
//and on the next two lines receives two numbers. Create four methods (for each calculation) 
//and invoke the right one depending on the command. 
//The method should also print the result (needs to be void)

using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add": 
                    Add(first, second); 
                    break;
                case "subtract":
                    Subtract(first, second);
                    break;
                case "multiply":
                    Multiply(first, second);
                    break;
                case "divide":
                    Divide(first, second);
                        break;
            }
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
