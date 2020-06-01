using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    /// <summary>
    /// 1 建立一个享元模式
    /// 2 和单例模式的区别
    /// 3 享元模式在.net里面的应用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课之设计模式特训，这里是Eleven老师为大家带来的享元模式");

            string teacher = "Eleven";
            string man = "Eleven";

            Console.WriteLine(teacher == man);//值
            Console.WriteLine(teacher.Equals(man));//值
            Console.WriteLine(Object.ReferenceEquals(teacher, man));//比较的是引用   string字符串的内存分配使用了享元模式

            StringBuilder sb = new StringBuilder();
            sb.Append("El");
            sb.Append("ev");
            sb.Append("en");

            string newMan = sb.ToString();

            Console.WriteLine(teacher == newMan);//值
            Console.WriteLine(teacher.Equals(newMan));//值
            Console.WriteLine(Object.ReferenceEquals(teacher, newMan));//比较的是引用 




            //打印老师的名字 eleven

            //AbstractCharactor e1 = new E();
            //AbstractCharactor l = new L();
            ////AbstractCharactor e2 = new E();
            //AbstractCharactor v = new V();
            ////AbstractCharactor e3 = new E();
            //AbstractCharactor n = new N();

            AbstractCharactor e1 = CharactorFactory.CreateCharactor(CharactorEnum.E);
            AbstractCharactor e2 = CharactorFactory.CreateCharactor(CharactorEnum.E);
            AbstractCharactor e3 = CharactorFactory.CreateCharactor(CharactorEnum.E);
            AbstractCharactor e4 = CharactorFactory.CreateCharactor(CharactorEnum.E);
            AbstractCharactor e5 = CharactorFactory.CreateCharactor(CharactorEnum.E);
            AbstractCharactor e6 = CharactorFactory.CreateCharactor(CharactorEnum.E);
            AbstractCharactor e7 = CharactorFactory.CreateCharactor(CharactorEnum.E);
            AbstractCharactor l = CharactorFactory.CreateCharactor(CharactorEnum.L);
            AbstractCharactor v = CharactorFactory.CreateCharactor(CharactorEnum.V);
            AbstractCharactor n = CharactorFactory.CreateCharactor(CharactorEnum.N);

            //Console.WriteLine("{0}{1}{2}{3}{4}{5}", e1.GetWord(), l.GetWord(), e2.GetWord(), v.GetWord(), e3.GetWord(), n.GetWord());

            Console.WriteLine("{0}{1}{2}{3}{4}{5}", e1.GetWord(), l.GetWord(), e1.GetWord(), v.GetWord(), e1.GetWord(), n.GetWord());






            Console.ReadKey();
        }
    }
}
