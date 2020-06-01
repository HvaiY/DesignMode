﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Mother : IObserver
    {
        public void Whisper()
        {
            Console.WriteLine("{0} {1}", this.GetType(), "Whisper");
        }
        public void Notify()
        {
            this.Whisper();
        }
    }
}
