//Write a program that receives an array and number of rotations you have to perform
//(first element goes at the end) Print the resulting array.
//Input:
//51 47 32 61 21
//2
//Output:
//32 61 21 51 47

using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int temp = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
