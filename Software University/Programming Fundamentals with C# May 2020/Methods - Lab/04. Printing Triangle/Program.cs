//Create a method for printing triangles as shown below:
//Input:    Output:
//  3	     1
//           1 2
//           1 2 3
//           1 2
//           1

using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintTriangle(1, i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintTriangle(1, i);
            }
        }

        static void PrintTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
        
    }
}
