using System;
using System.Linq;
using System.Text;

namespace testove
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert a string to a byte array:
            //string author = "Mahesh Chand";
            //byte[] bytes = Encoding.ASCII.GetBytes(author);
            //foreach (byte b in bytes)
            //{
            //    Console.WriteLine(b);
            //}

            //Convert a string to a char array:
            //string str = "abcde";
            //char[] chars = str.ToCharArray();
            //foreach (var item in chars)
            //{
            //    Console.WriteLine(item);
            //}

            string str = "123456789";

            int currentIndex = str.Length - 1;

            string reversed = string.Empty;

            while (currentIndex >= 0)
            {
                reversed += str[currentIndex];

                currentIndex--;
            }

            Console.WriteLine(reversed);
        }
    }
}
