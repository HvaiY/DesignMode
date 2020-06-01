using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /// <summary>
    /// 1 什么是代理模式
    /// 2 单例代理，异常代理....
    /// 
    /// 代理模式的扩展性：
    /// 1 单例代理 控制的是对象的实例化
    /// 2 异常代理 控制的是方法的执行
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课之设计模式特训课，今天是Eleven老师为大家带来的代理模式");
            //try
            //{
            //    ObjectClass objectClass = new ObjectClass();
            //    objectClass.GetSomething();
            //    objectClass.DoSomething();
            //}

            //catch (Exception ex)
            //{

            //    Console.WriteLine("出现异常，{0}", ex.Message);
            //}

            {
                IObjectClass objectClassProxy = new ObjectClassProxy();
                objectClassProxy.GetSomething();
                objectClassProxy.DoSomething();
            }

            {
                IObjectClass objectClassProxy = new ObjectClassProxy();
                objectClassProxy.GetSomething();
                objectClassProxy.DoSomething();

            }

            {
                IObjectClass objectClassProxy = new ObjectClassProxy();
                objectClassProxy.GetSomething();
                objectClassProxy.DoSomething();
            }


            {
                IObjectClass objectClassProxy = new ObjectClassProxy();
                objectClassProxy.GetSomething();
                objectClassProxy.DoSomething();
            }

            {
                IObjectClass objectClassProxy = new ObjectClassProxy();
                objectClassProxy.GetSomething();
                objectClassProxy.DoSomething();
            }
            Console.Read();
        }
    }
}
