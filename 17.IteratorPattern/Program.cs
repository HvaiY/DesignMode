using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 1 迭代器模式介绍 Iterator
    /// 2 .net里面的迭代器模式  yield return
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课之设计模式特训课，今天是Eleven老师为大家带来的迭代器模式");

            Console.WriteLine("当前时间{0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
            Collection collection = new Collection();
            //collection.GetEnumerator();
            foreach (int i in collection)
            {
                Console.WriteLine("{0}   {1}", DateTime.Now.ToString("yyyyMMddHHmmss"), i);
            }











            List<int> intList = new List<int>()
            {
                1,2,3,4,6,7,89,123,32,324,23,43,43,5,354,4
            };
            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("********************************************");

            DataContainer container = new DataContainer();

            while (!container.IsEnd())
            {
                Console.WriteLine(container.Get());
            }

            Console.WriteLine("*********************DataContainerIterator***********************");

            IIterator<int> iterator = new DataContainerIterator();

            while (!iterator.IsEnd())
            {
                Console.WriteLine(iterator.Get());
            }
            Console.Read();



        }
    }
}
