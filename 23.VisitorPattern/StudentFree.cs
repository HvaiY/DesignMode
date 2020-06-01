using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class StudentFree : Student
    {
        public override void GetVideo(IVisitor visitor)
        {
            visitor.GetVideoFree();
            //Console.WriteLine("免费学员可以获取当次课程的视频");
        }
    }
}
