using FacadeMode.DAL;
using FacadeMode.Interface;
using FacadeMode.InterfaceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode
{
    /// <summary>
    /// 订单系统
    /// </summary>
    public class Order : IOrder
    {
        public bool Check(int commodityId)
        {
            ICommodity iCommodity = new Commodity();

            int iResult = iCommodity.GetCount(commodityId);
            if (iResult < 1) return false;

            IShop iShop = new Shop();
            if (!iShop.CheckState(iShop.GetShopId(commodityId))) return false;

            Console.WriteLine("当前商品是可以购买的");
            return true;
        }
    }
}
