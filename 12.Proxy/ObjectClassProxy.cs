using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /// <summary>
    /// proxy
    /// </summary>
    public class ObjectClassProxy : IObjectClass
    {
        private static ObjectClass ObjectClass = null;
        private static object ObjectClassProxy_Lock = new object();

        public ObjectClassProxy()
        {
            if (ObjectClass == null)//初始化之后不再进入lock
            {
                lock (ObjectClassProxy_Lock)//防止多线程
                {
                    if (ObjectClass == null)//为空才创建
                    {
                        ObjectClass = new ObjectClass();
                    }
                }
            }
        }


        /// <summary>
        /// 做点事儿
        /// </summary>
        public void GetSomething()
        {
            try//异常代理   日志代理   邮件代理   事务代理   缓存代理  有效性代理  性能监控   记数代理
            {
                ObjectClass.GetSomething();
            }
            catch (Exception ex)
            {
                Console.WriteLine("出现异常，{0}", ex.Message);
            }
        }

        /// <summary>
        /// 获取点东西
        /// </summary>
        public void DoSomething()
        {
            try
            {

                ObjectClass.DoSomething();
            }
            catch (Exception ex)
            {

                Console.WriteLine("出现异常，{0}", ex.Message);
            }
        }


    }
}
