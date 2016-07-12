using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class SortedDictionaryPerformanceMeasurer : CollectionPerformanceMeasurer
    {
        SortedDictionary<int, int> dictionary;

        public SortedDictionaryPerformanceMeasurer() : base()
        {
            dictionary = new SortedDictionary<int, int>();
            CollectionName = "SortedDictionary";
        }

        public override void MeasureAddingElement()
        {
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < NumbersToAdd; i++)
            {
                dictionary.Add(i, i);
            }
            stopwatch.Stop();
            this.AddingTimespan = stopwatch.Elapsed;
        }

        public override void MeasureDeletingElement()
        {
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < NumbersToDelete; i++)
            {
                dictionary.Remove(i);
            }
            stopwatch.Stop();
            this.DeletingTimespan = stopwatch.Elapsed;
        }

        public override void MeasureFindingElement()
        {
            stopwatch.Reset();
            stopwatch.Start();
            dictionary.ContainsKey(this.NumberToFind);
            stopwatch.Stop();
            this.FindingTimespan = stopwatch.Elapsed;
        }

        public override void MeasureReadingElement()
        {
            stopwatch.Reset();
            stopwatch.Start();
            dictionary.ElementAt(this.IndexOfElementToRead);
            stopwatch.Stop();
            this.ReadingTimespan = stopwatch.Elapsed;
        }
    }
}
