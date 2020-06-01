using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class AbstratcLight
    {
        public LightState State
        {
            get;
            private set;
        }

        public AbstratcLight(LightState state)
        {
            this.State = state;
        }

        public abstract void Change(Context context);
    }
}
