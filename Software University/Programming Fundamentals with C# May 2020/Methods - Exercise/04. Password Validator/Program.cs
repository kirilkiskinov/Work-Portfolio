//Write a program that checks if a given password is valid. Password rules are:
//•	6 – 10 characters(inclusive)
//•	Consists only of letters and digits
//•	Have at least 2 digits
//If a password is valid print "Password is valid". 
//If it is not valid, for every unfulfilled rule print a message:
//•	"Password must be between 6 and 10 characters"
//•	"Password must consist only of letters and digits"
//•	"Password must have at least 2 digits"

using System;
using System.Text;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (ValidLength(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (ConsistsOnlyOfLettersAndDigits(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (AtLeast2Digits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (ValidLength(password) == true &&
                ConsistsOnlyOfLettersAndDigits(password) == true &&
                AtLeast2Digits(password) == true)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool ValidLength(string input)
        {
            bool isValid = false;

            if (input.Length >= 6 && input.Length <= 10)
            {
                isValid = true;
            }

            return isValid;
        }

        static bool ConsistsOnlyOfLettersAndDigits(string password)
        {
            bool isValid = true;

            byte[] bytes = Encoding.ASCII.GetBytes(password); //Convert a C# string to a byte array

            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] <= 47 || (bytes[i] >= 58 && bytes[i] <= 64) ||
                    (bytes[i] >= 91 && bytes[i] <= 96) || bytes[i] >= 123)
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        static bool AtLeast2Digits(string password)
        {
            bool isValid = false;

            byte digitsCount = 0;

            byte[] bytes = Encoding.ASCII.GetBytes(password); //Convert a C# string to a byte array

            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] >= 48 && bytes[i] <= 57)
                {
                    digitsCount++;
                }

                if (digitsCount == 2)
                {
                    isValid = true;
                    break;
                }
            }

            return isValid;
        }
    }
}
