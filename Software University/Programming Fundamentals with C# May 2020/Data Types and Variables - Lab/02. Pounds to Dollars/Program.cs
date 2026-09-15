//Write a program that converts British pounds to US dollars formatted to 3th decimal point.
//1 British Pound = 1.31 Dollars

using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            decimal dollars = pounds * 1.31M;     

            Console.WriteLine($"{dollars:F3}");            

        }
    }
}
