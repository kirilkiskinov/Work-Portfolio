using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            string isBalanced = "BALANCED";

            byte openingBracketCount = 0;
            byte closingBracketCount = 0;

            for (int i = 1; i <= n; i++)
            {
                string str = Console.ReadLine();                

                if (str == "(")
                {
                    openingBracketCount++;                    
                }
                else if (str == ")")
                {
                    closingBracketCount++;

                    if (closingBracketCount > openingBracketCount)
                    {
                        isBalanced = "UNBALANCED";                        
                        Console.WriteLine(isBalanced);
                        return;
                    }
                }               
            }

            if (openingBracketCount != closingBracketCount)
            {
                isBalanced = "UNBALANCED";
            }            

            Console.WriteLine(isBalanced);
        }
    }
}
