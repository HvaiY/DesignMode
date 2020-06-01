using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class BaseStrategy
    {
        public int LeftInput { get; set; }
        public int RightInput { get; set; }

        public abstract int Calculation();
    }
}
