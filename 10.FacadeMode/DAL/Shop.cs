using FacadeMode.InterfaceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode.DAL
{
    public class Shop : IShop
    {

        public int GetShopId(int commodityId)
        {
            return 3;
        }

        public bool CheckState(int shopId)
        {
            return shopId == 3;
        }
    }
}
