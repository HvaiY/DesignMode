using FacadeMode.InterfaceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode.DAL
{
    public class Commodity:ICommodity
    {

        public int GetCount(int commodityId)
        {
            return 100;
        }
    }
}
