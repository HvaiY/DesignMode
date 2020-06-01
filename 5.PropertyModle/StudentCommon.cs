using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyModle
{
    public class StudentCommon
    {
        public StudentCommon()//让我们创建对象的时候，麻烦一点
        {
            long lRsult = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                lRsult += i;
            }
            Console.WriteLine("构造函数计算完成 {0}", lRsult);
        }

        public string Name { get; set; }
    }
}
