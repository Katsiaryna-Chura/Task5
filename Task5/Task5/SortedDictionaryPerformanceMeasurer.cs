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
            s.Reset();
            s.Start();
            for (int i = 0; i < NumbersToAdd; i++)
            {
                dictionary.Add(i, i);
            }
            s.Stop();
            this.AddingTimespan = s.Elapsed;
        }

        public override void MeasureDeletingElement()
        {
            s.Reset();
            s.Start();
            for (int i = 0; i < NumbersToDelete; i++)
            {
                dictionary.Remove(i);
            }
            s.Stop();
            this.DeletingTimespan = s.Elapsed;
        }

        public override void MeasureFindingElement()
        {
            s.Reset();
            s.Start();
            dictionary.ContainsKey(this.NumberToFind);
            s.Stop();
            this.FindingTimespan = s.Elapsed;
        }

        public override void MeasureReadingElement()
        {
            s.Reset();
            s.Start();
            dictionary.ElementAt(this.IndexOfElementToRead);
            s.Stop();
            this.ReadingTimespan = s.Elapsed;
        }
    }
}
