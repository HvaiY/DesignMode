using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Collection : IEnumerable
    {
        private DateTime EndTime = DateTime.Now.AddSeconds(10);

        private int Get()
        {
            Thread.Sleep(1000);
            return DateTime.Now.Second;
        }

        /// <summary>
        /// 迭代
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            while (DateTime.Now < EndTime)
                yield return Get();
        }

        //数据集合 while (DateTime.Now < EndTime)  去Get()   组装成list  交出去遍历

        public List<int> GetData()
        {
            List<int> intList = new List<int>();
            while (DateTime.Now < EndTime)
            {
                intList.Add(Get());
            }
            return intList;
        }


    }
}
