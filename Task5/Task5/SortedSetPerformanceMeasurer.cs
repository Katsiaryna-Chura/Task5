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
            s.Reset();
            s.Start();
            for (int i = 0; i < NumbersToAdd; i++)
            {
                set.Add(i);
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
                set.Remove(i);
            }
            s.Stop();
            this.DeletingTimespan = s.Elapsed;
        }

        public override void MeasureFindingElement()
        {
            s.Reset();
            s.Start();
            set.Contains(this.NumberToFind);
            s.Stop();
            this.FindingTimespan = s.Elapsed;
        }

        public override void MeasureReadingElement()
        {
            s.Reset();
            s.Start();
            set.ElementAt(this.IndexOfElementToRead);
            s.Stop();
            this.ReadingTimespan = s.Elapsed;
        }
    }
}
