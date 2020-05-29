using ProgressBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProgressBarDemo
{
    class Program
    {
        static void Main()
        {
            AbstractBar bar;

            bar = new AnimatedBar();
            int wait = 100;
            int end = 50;

            //Animated bar
            Test(bar, wait, end);
            //Sway bar
            bar = new SwayBar();
            Test(bar, wait, end);

            //BlocksBar
            bar = new BlocksBar();
            Test(bar, wait, end);
            Console.ReadLine();
        }

        public static void Test(AbstractBar bar, int wait, int end) 
        {
            bar.PrintMessage("Loading...");
            for (int cont = 0; cont < end; cont++)
            {
                bar.PerformStep();
                Thread.Sleep(wait);
            }
            bar.PrintMessage("\nFinished");
        }
    }
}
