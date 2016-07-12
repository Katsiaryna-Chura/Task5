using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class PerformanceResultCalculator
    {
        List<CollectionPerformanceMeasurer> measurers;

        public PerformanceResultCalculator()
        {
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

        public string CalculateResultsForCollection(CollectionPerformanceMeasurer measurer)
        {
            measurer.MeasureAddingElement();
            measurer.MeasureDeletingElement();
            measurer.MeasureReadingElement();
            measurer.MeasureFindingElement();
            return measurer.GetAllTimespans();
        }

        public List<string> CalculateOverallResults()
        {
            List<string> results = new List<string>();
            MeasurersInitialize();
            foreach (var measurer in measurers)
            {
                results.Add($"{CalculateResultsForCollection(measurer)}");
            }
            return results;
        }
    }
}
