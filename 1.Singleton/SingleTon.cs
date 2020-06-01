using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MySingleton
{
    public class Singleton
    {
        private static bool IsInit = false;
        private static object Singleton_Lock = new object();

        private long LResult = 0;
        private Singleton()
        {
            //lock (Singleton_Lock)
            //{
            //if (IsInit == false)
            //{
            for (int i = 0; i < 1000000000; i++)
            {
                LResult += i;
            }

            Console.WriteLine("在这里被初始化了,LResult={0},ThreadId={1}", LResult, Thread.CurrentThread.ManagedThreadId);
            //    IsInit = true;
            //}
            //else
            //{
            //    Console.WriteLine("**************,LResult={0},ThreadId={1}", LResult, Thread.CurrentThread.ManagedThreadId);
            //}
            //}
        }

        private static Singleton _Singleton = null;

        public static Singleton CreateInstance()
        {
            if (_Singleton == null)//先看看是否初始化过
            {
                lock (Singleton_Lock)//一开始线程都等待这里
                {
                    if (_Singleton == null)//还是检测是否为空
                    {
                        _Singleton = new Singleton();
                    }
                }
            }
            return _Singleton;
        }


        public int Id { get; set; }

        public void SayHi()
        {
            Console.WriteLine("早上好，如何正确的瞎吐槽丶");
        }

        public long GetResult()
        {
            return LResult;
        }
    }
}
