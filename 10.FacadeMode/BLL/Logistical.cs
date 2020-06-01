using FacadeMode.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode
{
    /// <summary>
    /// 物流系统
    /// </summary>
    public class Logistical : ILogistical
    {
        public bool Check(int cityId)
        {
            Console.WriteLine("当前城市物流是可达的");
            return true;
        }
    }
}
