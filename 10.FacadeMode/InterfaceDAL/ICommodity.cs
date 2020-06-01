using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode.InterfaceDAL
{
    public interface ICommodity
    {
        int GetCount(int commodityId);

    }
}
