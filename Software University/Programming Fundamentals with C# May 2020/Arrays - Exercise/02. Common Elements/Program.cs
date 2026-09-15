//Write a program, which prints common elements in two arrays. You have to compare the 
//elements of the second array to the elements of the first.

using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();

            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i] == array1[j])
                    {
                        Console.Write(array2[i] + " ");
                    }
                }
            }
        }
    }
}
