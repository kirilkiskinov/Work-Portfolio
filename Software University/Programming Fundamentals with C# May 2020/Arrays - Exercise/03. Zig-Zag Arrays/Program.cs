//Write a program which creates 2 arrays. You will be given an integer n. On the next n lines
//you get 2 integers. Form 2 arrays as shown below.
//Input:
//2
//80 23
//31 19
//Output:
//80 19
//23 31

using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            int line = 1;

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (line % 2 == 0)
                {
                    array1[i] = input[1];
                    array2[i] = input[0];
                }
                else
                {
                    array1[i] = input[0];
                    array2[i] = input[1];
                }

                line++;
            }

            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}
