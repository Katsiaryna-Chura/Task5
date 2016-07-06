using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task5
{
    public class ResultWriter
    {
        public string FilePath { get; private set; }
        List<string> results;

        public ResultWriter()
        {
            FilePath = FileData.Path;
            results = new List<string>();
        }

        public void WriteResultsToFile()
        {
            File.WriteAllText(FilePath, "The comparison includes operations:\nadding 1000 elements\ndeleting 100 elements\nreading element 125\nfinding element with index 50\n");
            File.AppendAllText(FilePath, "                      Add  Delete    Read    Find\n");
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
            CollectionPerformanceMeasurer measurer = new ListPerformanceMeasurer();
            results.Add($"List              {CalculateResultsForCollection(measurer)}");
            measurer = new LinkedListPerformanceMeasurer();
            results.Add($"LinkedList        {CalculateResultsForCollection(measurer)}");
            measurer = new DictionaryPerformanceMeasurer();
            results.Add($"Dictionary        {CalculateResultsForCollection(measurer)}");
            measurer = new QueuePerformanceMeasurer();
            results.Add($"Queue             {CalculateResultsForCollection(measurer)}");
            measurer = new StackPerformanceMeasurer();
            results.Add($"Stack             {CalculateResultsForCollection(measurer)}");
            measurer = new SortedSetPerformanceMeasurer();
            results.Add($"SortedSet         {CalculateResultsForCollection(measurer)}");
            measurer = new SortedDictionaryPerformanceMeasurer();
            results.Add($"SortedDictionary  {CalculateResultsForCollection(measurer)}");
        }
    }
}
