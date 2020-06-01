using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// 1 集合的访问和访问者模式Visitor Pattern
    /// 2 倾斜的可扩展性设计
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课之设计模式特训课，今天是Eleven老师为大家带来的访问者模式");

            List<Student> studentList = new List<Student>();
            studentList.Add(new StudentVip()
                             {
                                 Name = "飞粤黄河",
                                 QQ = 552348835
                             });
            studentList.Add(new StudentVip()
            {
                Name = "暖阳",
                QQ = 1835621554

            });

            studentList.Add(new StudentFree()
            {
                Name = "ANDY",
                QQ = 28281539
            });

            studentList.Add(new StudentFree()
            {
                Name = "YC",
                QQ = 674965171
            });

            Console.WriteLine("****************VisitorBefore********************");
            foreach (Student student in studentList)
            {
                Console.WriteLine("QQ={0} Name={1}", student.QQ, student.Name);
                //if (student is StudentFree)&&before  VisitorBefore.GetVideoFree
                //{
                //    Console.WriteLine("免费学员可以获取当次课程的视频");
                //}
                //else if (student is StudentVip)
                //{
                //    Console.WriteLine("vip学员可以获取全部课程的视频课件和代码");
                //}

                //if (student is StudentFree && before)
                //{
                //    VisitorBefore.GetVideoFree(); 1
                //}
                //else if (student is StudentFree && now)
                //{
                //    VisitorNow.GetVideoFree(); 2
                //}
                //else if (student is StudentVip && before)
                //{
                //    VisitorBefore.GetVideoVip(); 3
                //}
                //else if (student is StudentVip && now)
                //{
                //    VisitorNow.GetVideoVip(); 4
                //}

                //student.GetVideo();

                student.GetVideo(new VisitorBefore());
               
            }
            Console.WriteLine("****************VisitorNow********************");
            foreach (Student student in studentList)
            {
                Console.WriteLine("QQ={0} Name={1}", student.QQ, student.Name);
                student.GetVideo(new VisitorNow());

            }
            


            Console.Read();
        }
    }
}
