using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Lumia : BasePhone
    {
        public override void Call()
        {
            Console.WriteLine("使用{0} {1}打电话", this.GetType(), CurrentSystem.System());
        }

        public override void Message()
        {
            Console.WriteLine("使用{0} {1}发短信", this.GetType(), CurrentSystem.System());
        }
    }
}
