using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    /// <summary>
    /// 牧师
    /// </summary>
    public class Minister : CharactorBase
    {

        public override void Show()
        {
            Console.WriteLine("这里是牧师 卖血上的网");
        }
    }
}
