using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /// <summary>
    /// real
    /// </summary>
    public class ObjectClass : IObjectClass
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ObjectClass()
        {
            Console.WriteLine("ObjectClass real 实例化");
        }


        /// <summary>
        /// 做点事儿
        /// </summary>
        public void GetSomething()
        {
            Console.WriteLine("ObjectClass real GetSomething");
        }

        /// <summary>
        /// 获取点东西
        /// </summary>
        public void DoSomething()
        {
            Console.WriteLine("ObjectClass real DoSomething");
        }


    }
}
