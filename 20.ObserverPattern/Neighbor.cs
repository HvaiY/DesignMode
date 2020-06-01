using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Neighbor : IObserver
    {
        public void Awake()
        {
            Console.WriteLine("{0} {1}", this.GetType(), "Awake");
        }
        public void Notify()
        {
            this.Awake();
        }
    }
}
