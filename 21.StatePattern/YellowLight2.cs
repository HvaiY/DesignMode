using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class YellowLight2 : AbstratcLight
    {
        public YellowLight2()
            : base(LightState.Yellow2)
        {
        }

        public override void Change(Context context)
        {
            Console.WriteLine("当前的颜色是 {0},change一下", this.State.ToString());
            //Change 黄
            context.Set(new GreenLight());

        }
    }
}
