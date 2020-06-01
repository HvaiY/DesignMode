using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MySingleton
{
    /// <summary>
    /// 单例模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();


            //for (int i = 0; i < 10; i++)
            //{
            //    Singleton singleton = new Singleton();//实例化
            //    singleton.SayHi();
            //    Console.WriteLine("最终需要的是{0}", singleton.GetResult());
            //}
            List<Task> taskList = new List<Task>();
            TaskFactory taskFactory = new TaskFactory();
            for (int i = 0; i < 10; i++)
            {
                taskList.Add(taskFactory.StartNew(() =>
                     {
                         //Singleton singleton = new Singleton();//外面实例化
                         SingletonSecond singleton = SingletonSecond.CreateInstance();
                         singleton.SayHi();
                         Console.WriteLine("最终需要的是{0},,ThreadId={1}", singleton.GetResult(), Thread.CurrentThread.ManagedThreadId);
                     }));
            }
            Task.WaitAll(taskList.ToArray());

            stopwatch.Stop();
            Console.WriteLine("一共耗时 {0}毫秒", stopwatch.ElapsedMilliseconds);
            for (int i = 0; i < 10; i++)
            {
                taskList.Add(taskFactory.StartNew(() =>
                {
                    //Singleton singleton = new Singleton();//外面实例化
                    Singleton singleton = Singleton.CreateInstance();
                    singleton.SayHi();
                    Console.WriteLine("最终需要的是{0},,ThreadId={1}", singleton.GetResult(), Thread.CurrentThread.ManagedThreadId);
                }));
            }

            Console.ReadKey();
        }
    }
}
