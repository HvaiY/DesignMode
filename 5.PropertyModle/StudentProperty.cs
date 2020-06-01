using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyModle
{
    [Serializable]
    public class StudentProperty
    {
        private StudentProperty()//让我们创建对象的时候，麻烦一点
        {
            long lRsult = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                lRsult += i;
            }
            Console.WriteLine("构造函数计算完成 {0}", lRsult);
        }
        private static StudentProperty _StudentProperty = null;

        static StudentProperty()
        {
            _StudentProperty = new StudentProperty();
            _StudentProperty.Name = "tumi";
            _StudentProperty.Class = new Advanced()
            {
                Id = 1,
                Name = ".Net高级班"
            };
        }

        public static StudentProperty Clone()
        {
            StudentProperty studentCopy = (StudentProperty)_StudentProperty.MemberwiseClone();
            return studentCopy;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Now { get; set; }
        public Advanced Class { get; set; }


    }

    [Serializable]
    public class Advanced
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
