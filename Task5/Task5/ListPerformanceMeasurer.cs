using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class ListPerformanceMeasurer : CollectionPerformanceMeasurer
    {
        List<int> list;

        public ListPerformanceMeasurer() : base()
        {
            list = new List<int>();
            CollectionName = "List";
        }

        public override void MeasureAddingElement()
        {
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < NumbersToAdd; i++)
            {
                list.Add(i);
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
                list.Remove(i);
            }
            stopwatch.Stop();
            this.DeletingTimespan = stopwatch.Elapsed;
        }

        public override void MeasureFindingElement()
        {
            stopwatch.Reset();
            stopwatch.Start();
            list.Contains(this.NumberToFind);
            stopwatch.Stop();
            this.FindingTimespan = stopwatch.Elapsed;
        }

        public override void MeasureReadingElement()
        {
            stopwatch.Reset();
            stopwatch.Start();
            list.ElementAt(this.IndexOfElementToRead);
            stopwatch.Stop();
            this.ReadingTimespan = stopwatch.Elapsed;
        }

    }
}
