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
        }

        public override void MeasureAddingElement()
        {
            s.Reset();
            s.Start();
            for (int i = 0; i < NumberToAdd; i++)
            {
                stack.Push(i);
            }
            s.Stop();
            this.AddingTimespan = s.Elapsed;
        }

        public override void MeasureDeletingElement()
        {
            s.Reset();
            s.Start();
            for (int i = 0; i < NumberToDelete; i++)
            {
                stack.Pop();
            }
            s.Stop();
            this.DeletingTimespan = s.Elapsed;
        }

        public override void MeasureFindingElement()
        {
            s.Reset();
            s.Start();
            stack.Contains(this.NumberToFind);
            s.Stop();
            this.FindingTimespan = s.Elapsed;
        }

        public override void MeasureReadingElement()
        {
            s.Reset();
            s.Start();
            stack.ElementAt(this.IndexOfElementToRead);
            s.Stop();
            this.ReadingTimespan = s.Elapsed;
        }
    }
}
