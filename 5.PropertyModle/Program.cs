using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyModle
{
    /// <summary>
    /// 1 原型模式
    /// 2 浅表复制和深表复制
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到.net高级班公开课程");

            //Student student1 = Student.CreateInstanceSingleton();
            //student1.Name = "爱好者";

            //Student student2 = Student.CreateInstanceSingleton();
            //student2.Name = "简单点好";
            //Student student3 = Student.CreateInstanceSingleton();
            //Student student4 = Student.CreateInstanceSingleton();







            StudentProperty studentProperty1 = StudentProperty.Clone();
            studentProperty1.Name = "你若离去へ后会无期";
            studentProperty1.Id = 1;
            studentProperty1.Now = DateTime.Now;


            StudentProperty studentProperty2 = StudentProperty.Clone();
            studentProperty2.Name = "1988(1988)";
            studentProperty2.Id = 2;
            studentProperty2.Now = DateTime.Now.AddDays(1);


            studentProperty2.Class.Name = "Eleven's .Net高级班";


            StudentProperty studentProperty3 = SerializeHelper.Derializable<StudentProperty>(SerializeHelper.Serializable(studentProperty2));//借助序列化，实现深克隆
            studentProperty3.Class.Name = "Eleven's .Net深度学习高级班";



            //StudentProperty studentProperty3 = StudentProperty.Clone();
            //StudentProperty studentProperty4 = StudentProperty.Clone();

            //StudentCommon studentCommon1 = new StudentCommon();
            //studentCommon1.Name = " 番茄沙司 Melissa(163-番茄-上海)";

            //StudentCommon studentCommon2 = new StudentCommon();
            //studentCommon2.Name = "知心dě朋友=(192-杰仔-男-广州)"; 


            Console.Read();
        }
    }
}
