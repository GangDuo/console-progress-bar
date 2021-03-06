﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgressBar
{
    public class AnimatedBar : AbstractBar
    {
        List<string> animation;
        int counter;
        public AnimatedBar() : base()
        {
            this.animation = new List<string> { "/", "-", @"\", "|" };
            this.counter = 0;
        }

        /// <summary>
        /// prints the character found in the animation according to the current index
        /// </summary>
        public override void PerformStep() {
            Console.Write("\r");
            Console.Write(this.animation[this.counter]+"\b");
            this.counter++;
            if (this.counter == this.animation.Count)
                this.counter = 0;
        }
    }
}
