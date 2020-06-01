using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class OrcFactory : IFactoryMethod
    {
        public IRace CreateInstance()
        {
            return new Orc();
        }
    }
}
