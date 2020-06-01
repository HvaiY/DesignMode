using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class PlusStrategy : BaseStrategy
    {
        /// <summary>
        /// 1.0
        /// </summary>
        /// <returns></returns>
        public override int Calculation()
        {
            return LeftInput + RightInput;
        }
    }

    public class PlusStrategy2 : PlusStrategy
    {
        /// <summary>
        /// 2.0
        /// </summary>
        /// <returns></returns>
        public override int Calculation()
        {
            return LeftInput + RightInput + 1;
        }
    }
}
