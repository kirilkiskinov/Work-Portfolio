using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int books = int.Parse(Console.ReadLine());

            string currentBookName = Console.ReadLine();

            int booksCount = 0;

            while (bookName != currentBookName)
            {
                booksCount++;

                if (booksCount >= books)
                {
                    break;
                }

                currentBookName = Console.ReadLine();
            }
            if (booksCount < books)
            {
                Console.WriteLine($"You checked {booksCount} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {booksCount} books.");
            }
        }
    }
}

