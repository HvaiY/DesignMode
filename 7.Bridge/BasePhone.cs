using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class BasePhone
    {
        public ISystem CurrentSystem = null;
        public IOperator CurrentOperator = null;
        //public abstract string System();
        public abstract void Call();
        public abstract void Message();
    }
}
