using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class DictionaryPerformanceMeasurer : CollectionPerformanceMeasurer
    {
        Dictionary<int, int> dictionary;

        public DictionaryPerformanceMeasurer() : base()
        {
            dictionary = new Dictionary<int, int>();
            CollectionName = "Dictionary";
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
