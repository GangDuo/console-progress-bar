﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgressBar
{
    abstract public class AbstractBar
    {
        /// <summary>
        /// Prints a simple message 
        /// </summary>
        /// <param name="msg">Message to print</param>
        public void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        public abstract void PerformStep();
    }
}
