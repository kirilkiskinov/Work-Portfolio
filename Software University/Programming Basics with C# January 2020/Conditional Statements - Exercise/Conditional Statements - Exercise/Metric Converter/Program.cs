using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine()); // number for conversion
            string metricInput = Console.ReadLine();
            string metricOutput = Console.ReadLine();

            double resultValue; 

            if (metricInput == "mm" && metricOutput == "cm")
            {
                resultValue  = number * 0.1;
                Console.WriteLine($"{resultValue:F3}");
            }

           else if (metricInput == "mm" && metricOutput == "m")
            {
                resultValue = number * 0.001;
                Console.WriteLine($"{resultValue:F3}");
            }

           else if (metricInput == "cm" && metricOutput == "mm")
            {
                resultValue = number * 10;
                Console.WriteLine($"{resultValue:F3}");
            }

           else if (metricInput == "cm" && metricOutput == "m")
            {
                resultValue = number * 0.01;
                Console.WriteLine($"{resultValue:F3}");
            }

           else if (metricInput == "m" && metricOutput == "cm")
            {
                resultValue = number * 100;
                Console.WriteLine($"{resultValue:F3}");
            }

           else if (metricInput == "m" && metricOutput == "mm")
            {
                resultValue = number * 1000;
                Console.WriteLine($"{resultValue:F3}");
            }
        }
    }
}
