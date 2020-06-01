using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode.InterfaceDAL
{
    public interface IShop
    {
        int GetShopId(int commodityId);

        bool CheckState(int shopId);
    }
}
