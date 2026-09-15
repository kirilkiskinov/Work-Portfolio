using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(printText("C#")); 
        }

        public void printText(string text)
        {
            Console.WriteLine("I love" + text);
        }
    }
}
