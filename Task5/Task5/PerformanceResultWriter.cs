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
        List<CollectionPerformanceMeasurer> measurers;
        List<string> results;

        public PerformanceResultWriter()
        {
            FilePath = Data.ResultFilePath;
            results = new List<string>();
            measurers = new List<CollectionPerformanceMeasurer>();
        }

        public void MeasurersInitialize()
        {
            measurers.Add(new ListPerformanceMeasurer());
            measurers.Add(new LinkedListPerformanceMeasurer());
            measurers.Add(new DictionaryPerformanceMeasurer());
            measurers.Add(new QueuePerformanceMeasurer());
            measurers.Add(new StackPerformanceMeasurer());
            measurers.Add(new SortedSetPerformanceMeasurer());
            measurers.Add(new SortedDictionaryPerformanceMeasurer());
        }

        public void WriteResultsToFile()
        {
            File.WriteAllText(FilePath, $"{"Operation",-20} {"Add",8} {"Delete",8} {"Read",8} {"Find",8}\n\n");
            foreach (var result in results)
            {
                File.AppendAllText(FilePath, result);
            }
        }

        public string CalculateResultsForCollection(CollectionPerformanceMeasurer measurer)
        {
            measurer.MeasureAddingElement();
            measurer.MeasureDeletingElement();
            measurer.MeasureReadingElement();
            measurer.MeasureFindingElement();
            return measurer.GetAllTimespans();
        }

        public void CalculateOverallResults()
        {
            MeasurersInitialize();
            foreach (var measurer in measurers)
            {
                results.Add($"{CalculateResultsForCollection(measurer)}");
            }
        }
    }
}
