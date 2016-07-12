using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class StackPerformanceMeasurer : CollectionPerformanceMeasurer
    {
        Stack<int> stack;

        public StackPerformanceMeasurer() : base()
        {
            stack = new Stack<int>();
            CollectionName = "Stack";
        }

        public override void MeasureAddingElement()
        {
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < NumbersToAdd; i++)
            {
                stack.Push(i);
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
                stack.Pop();
            }
            stopwatch.Stop();
            this.DeletingTimespan = stopwatch.Elapsed;
        }

        public override void MeasureFindingElement()
        {
            stopwatch.Reset();
            stopwatch.Start();
            stack.Contains(this.NumberToFind);
            stopwatch.Stop();
            this.FindingTimespan = stopwatch.Elapsed;
        }

        public override void MeasureReadingElement()
        {
            stopwatch.Reset();
            stopwatch.Start();
            stack.ElementAt(this.IndexOfElementToRead);
            stopwatch.Stop();
            this.ReadingTimespan = stopwatch.Elapsed;
        }
    }
}
