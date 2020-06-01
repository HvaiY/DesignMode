using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode
{
    /// <summary>
    /// Facade 外观模式  门面模式
    /// 外观模式就是一种封装,把客户端和子系统通过外观类解除耦合，
    /// 三层模式就是最好的体现
    /// </summary>
    class Program
    {
        /// <summary>
        /// ui层
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课之设计模式特训，今天是外观模式Facade");
            int userId = 11;
            int cityId = 188;
            int commodityId = 5726;

            FacadeCenter facadeCenter = new FacadeCenter();
            if (!facadeCenter.CheckUserOrder(userId, commodityId, cityId))
            {
                Console.WriteLine("检测未通过，不能购买");
                return;//表示方法结束  不能购买
            }

            //User user = new User();
            //if (!user.Check(userId))
            //{
            //    return;
            //}

            //Order order = new Order();
            //if (!order.Check(commodityId))
            //{
            //    return;
            //}

            //Logistical logistical = new Logistical();
            //if (!logistical.Check(cityId))
            //{
            //    return;
            //}

            Console.WriteLine("可以购买，do it");
            Console.Read();
        }
    }
}
