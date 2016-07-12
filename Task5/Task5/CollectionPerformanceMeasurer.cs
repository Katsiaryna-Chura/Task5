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

        public int NumbersToAdd { get; protected set; }
        public int NumbersToDelete { get; protected set; }
        public int NumberToFind { get; protected set; }
        public int IndexOfElementToRead { get; protected set; }

        public string CollectionName { get; protected set; }

        protected Stopwatch stopwatch;

        public CollectionPerformanceMeasurer()
        {
            NumbersToAdd = int.Parse(Data.NumbersToAdd);
            NumbersToDelete = int.Parse(Data.NumbersToDelete);
            NumberToFind = int.Parse(Data.NumberToFind);
            IndexOfElementToRead = int.Parse(Data.IndexOfNumberToRead);

            stopwatch = new Stopwatch();
        }

        public abstract void MeasureAddingElement();
        public abstract void MeasureDeletingElement();
        public abstract void MeasureReadingElement();
        public abstract void MeasureFindingElement();

        public string GetAllTimespans()
        {
            return $"{CollectionName,-20} {AddingTimespan.TotalMilliseconds:0.0000,10} {DeletingTimespan.TotalMilliseconds:0.0000,10} {ReadingTimespan.TotalMilliseconds:0.0000,10} {FindingTimespan.TotalMilliseconds:0.0000,10}\n";
        }
    }
}
