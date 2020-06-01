using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class StudentVip : Student
    {
        public override void GetVideo(IVisitor visitor)
        {
            visitor.GetVideoVip();
            //Console.WriteLine("vip学员可以获取全部课程的视频课件和代码");
        }
    }
}
