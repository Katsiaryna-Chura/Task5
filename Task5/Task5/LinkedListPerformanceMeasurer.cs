using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class LinkedListPerformanceMeasurer : CollectionPerformanceMeasurer
    {
        LinkedList<int> linkedList;

        public LinkedListPerformanceMeasurer() : base()
        {
            linkedList = new LinkedList<int>();
            CollectionName = "LinkedList";
        }

        public override void MeasureAddingElement()
        {
            s.Reset();
            s.Start();
            for (int i = 0; i < NumbersToAdd; i++)
            {
                linkedList.AddLast(i);
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
                linkedList.Remove(i);
            }
            s.Stop();
            this.DeletingTimespan = s.Elapsed;
        }

        public override void MeasureFindingElement()
        {
            s.Reset();
            s.Start();
            linkedList.Contains(this.NumberToFind);
            s.Stop();
            this.FindingTimespan = s.Elapsed;
        }

        public override void MeasureReadingElement()
        {
            s.Reset();
            s.Start();
            linkedList.ElementAt(this.IndexOfElementToRead);
            s.Stop();
            this.ReadingTimespan = s.Elapsed;
        }
    }
}
