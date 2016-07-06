using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public abstract class CollectionPerformanceMeasurer
    {
        public TimeSpan AddingTimespan { get; protected set; }
        public TimeSpan DeletingTimespan { get; protected set; }
        public TimeSpan ReadingTimespan { get; protected set; }
        public TimeSpan FindingTimespan { get; protected set; }
        public int NumberToAdd = 1000;
        public int NumberToDelete = 100;
        public int NumberToFind = 125;
        public int IndexOfElementToRead = 50;
        protected Stopwatch s;

        public CollectionPerformanceMeasurer()
        {
            s = new Stopwatch();
        }

        public abstract void MeasureAddingElement();
        public abstract void MeasureDeletingElement();
        public abstract void MeasureReadingElement();
        public abstract void MeasureFindingElement();

        public string GetAllTimespans()
        {
            return $"{AddingTimespan.TotalMilliseconds:0.0000,7} {DeletingTimespan.TotalMilliseconds:0.0000,7} {ReadingTimespan.TotalMilliseconds:0.0000,7} {FindingTimespan.TotalMilliseconds:0.0000,7}\n";
        }
    }
}
