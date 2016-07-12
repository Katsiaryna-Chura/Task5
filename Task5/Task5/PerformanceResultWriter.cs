using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task5
{
    public class PerformanceResultWriter
    {
        public string FilePath { get; private set; }
        public List<string> Results{ get; set; }

        public PerformanceResultWriter()
        {
            FilePath = Data.ResultFilePath;
            Results = new List<string>();
        }

        public void WriteResultsToFile()
        {
            File.WriteAllText(FilePath, $"{"Operation",-20} {"Add",8} {"Delete",8} {"Read",8} {"Find",8}\n\n");
            foreach (var result in Results)
            {
                File.AppendAllText(FilePath, result);
            }
        }
    }
}
