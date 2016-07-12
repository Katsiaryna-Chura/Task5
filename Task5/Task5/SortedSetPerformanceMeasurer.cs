using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class SortedSetPerformanceMeasurer : CollectionPerformanceMeasurer
    {
        SortedSet<int> set;

        public SortedSetPerformanceMeasurer() : base()
        {
            set = new SortedSet<int>();
            CollectionName = "SortedSet";
        }

        public override void MeasureAddingElement()
        {
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < NumbersToAdd; i++)
            {
                set.Add(i);
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
                set.Remove(i);
            }
            stopwatch.Stop();
            this.DeletingTimespan = stopwatch.Elapsed;
        }

        public override void MeasureFindingElement()
        {
            stopwatch.Reset();
            stopwatch.Start();
            set.Contains(this.NumberToFind);
            stopwatch.Stop();
            this.FindingTimespan = stopwatch.Elapsed;
        }

        public override void MeasureReadingElement()
        {
            stopwatch.Reset();
            stopwatch.Start();
            set.ElementAt(this.IndexOfElementToRead);
            stopwatch.Stop();
            this.ReadingTimespan = stopwatch.Elapsed;
        }
    }
}
