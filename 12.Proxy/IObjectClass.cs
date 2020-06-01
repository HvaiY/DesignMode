using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
   public  interface IObjectClass
    {
        /// <summary>
        /// 做点事儿
        /// </summary>
       void GetSomething();

        /// <summary>
        /// 获取点东西
        /// </summary>
       void DoSomething();
    }
}
