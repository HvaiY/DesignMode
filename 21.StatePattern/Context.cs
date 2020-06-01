using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Context
    {

        private AbstratcLight Light = null;

        public Context(AbstratcLight light)
        {
            this.Light = light;
        }

        public void Change()
        {
            this.Light.Change(this);
        }

        public void Set(AbstratcLight light)
        {
            this.Light = light;
        }

    }
}
