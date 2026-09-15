using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examHourToMinutes = examHour * 60 + examMinutes;
            int arrivalHourToMinutes = arrivalHour * 60 + arrivalMinutes;

            int difference = arrivalHourToMinutes - examHourToMinutes;

            int hours = Math.Abs(difference / 60);
            int minutes = Math.Abs(difference % 60);

            if (difference < -30)
            {
                Console.WriteLine("Early");
            }
            else if (difference <= 0)
            {
                Console.WriteLine("On time");
            }
            else 
            {
                Console.WriteLine("Late");
            }

            if (hours > 0)
            {                
                if  (difference < 0)
                {
                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }
                else if (difference > 0)
                {
                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }                
            }
            else
            {                                
                if (difference < 0)
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }                
                else if (difference > 0)
                {
                    Console.WriteLine($"{minutes} minutes after the start");
                }
            }
        }
    }
}
