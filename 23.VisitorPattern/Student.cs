using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Student
    {
        public int QQ { get; set; }
        public string Name { get; set; }

        public virtual void GetVideo(IVisitor visitor)
        {

        }
    }
}
