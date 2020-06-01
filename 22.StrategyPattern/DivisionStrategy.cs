using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class DivisionStrategy : BaseStrategy
    {
        public override int Calculation()
        {
            if (base.RightInput == 0)
            {
                Console.WriteLine("除数不能为0，计算失败");
                //return 0;//应该终止计算
                throw new Exception("除数不能为0，计算失败");
            }
            return LeftInput * RightInput;
        }
    }
}
