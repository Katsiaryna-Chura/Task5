using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformanceResultCalculator calculator = new PerformanceResultCalculator();
            PerformanceResultWriter writer = new PerformanceResultWriter();
            writer.Results = calculator.CalculateOverallResults();
            writer.WriteResultsToFile();
            Console.WriteLine($"Results are written to the file {Data.ResultFilePath}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
