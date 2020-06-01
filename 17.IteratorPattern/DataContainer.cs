using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 想遍历这些元素  
    /// </summary>
    public class DataContainer
    {
        private List<int> IntList = new List<int>()
            {
                1,2,3,4,6,7,89,123,32,324,23,43,43,5,354,4
            };

        //public List<int> IntListPublic()
        //{ 
        //    return this.IntList;
        //}


        private int Index = 0;
        public int Get()
        {
            return IntList[Index++];
        }

        public bool IsEnd()
        {
            return Index >= IntList.Count();

        }
    }


}
