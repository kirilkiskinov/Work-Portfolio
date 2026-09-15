//You will be given 3 lines of input – student name, age and average grade.
//Your task is to print all the info about the student in the following format:
//"Name: {student name}, Age: {student age}, Grade: {student grade}".

using System;

namespace Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int studentAge = int.Parse(Console.ReadLine());
            double studentGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {studentGrade:F2}");

        }
    }
}
