//You will receive an input until you receive "END". Find what data type is the input. 
//Possible data types are:
//•	Integer 
//•	Floating point
//•	Characters
//•	Boolean
//•	Strings
//Print the result in the following format: "{input} is {data type} type".

using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string dataType = "string";

                if (Int32.TryParse(input, out int intNumber))
                {
                    dataType = "integer";
                    Console.WriteLine($"{input} is {dataType} type"); 
                }
                else if (Double.TryParse(input, out double doubleNumber))
                {
                    dataType = "floating point";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (Char.TryParse(input, out char character))
                {
                    dataType = "character";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (Boolean.TryParse(input, out bool boolean))
                {
                    dataType = "boolean";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else 
                {                    
                    Console.WriteLine($"{input} is {dataType} type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
