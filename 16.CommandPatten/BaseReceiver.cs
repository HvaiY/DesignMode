using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatten
{
    public abstract class BaseReceiver
    {
        public abstract void Execute(Document doc);
    }
}
