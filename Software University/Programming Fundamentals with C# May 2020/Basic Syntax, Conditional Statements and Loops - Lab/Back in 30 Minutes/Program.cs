//Every time Stamat tries to pay his bills he sees on the cash desk the sign: "I will be back in 30 minutes". 
//One day Stamat was sick of waiting and decided he needs a program, which prints the time after 30 minutes. 
//That way he won’t have to wait on the desk and come at the appropriate time. 
//He gave the assignment to you, so you have to do it.


using System;

namespace Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;            

            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }

            if (hours == 24)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");

        }
    }
}
