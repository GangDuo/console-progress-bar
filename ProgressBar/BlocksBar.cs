using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgressBar
{
    public class BlocksBar : AbstractBar
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        int Value { get; set; }
        int Step { get; set; }
        int Width { get; set; }

        public BlocksBar()
        {
            Minimum = 0;
            Maximum = 100;
            Value = 0;
            Step = 1;
            Width = 20;
        }

        public override void PerformStep()
        {
            if (Maximum <= Value) return;
            Console.Write("\r");
            Value += Step;
            int i = (int)((double)Value / (double)Maximum * Width);
            Console.Write("[" + String.Join("", Enumerable.Repeat("#", i)) + String.Join("", Enumerable.Repeat(" ", Width - i)) + "] " + Value + "%");
            Action<string> f = Console.Write;
        }
    }
}
