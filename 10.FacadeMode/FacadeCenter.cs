using FacadeMode.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode
{
    /// <summary>
    /// 外观中心
    /// </summary>
    public class FacadeCenter
    {
        public bool CheckUserOrder(int userId, int commodityId, int cityId)
        {
            IUser user = new User();//简单工厂+反射
            IOrder order = new Order();
            ILogistical logistical = new Logistical();

            return user.Check(userId) && order.Check(commodityId) && logistical.Check(cityId);
        }
    }
}
