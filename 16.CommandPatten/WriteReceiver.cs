using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatten
{
    public class WriteReceiver : BaseReceiver
    {
        public override void Execute(Document doc)
        {
            Console.WriteLine("{0} Write,{1}", this.GetType(), doc.Content);
        }
    }
}
