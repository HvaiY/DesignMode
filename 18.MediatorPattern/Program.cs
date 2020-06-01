using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 1 中介者模式（Mediator Pattern）
    /// 2 中介者模式的优缺点和应用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课之设计模式特训课，今天是Eleven老师为大家带来的中介者模式");

            SomebodyA somebodyA = new SomebodyA("梦");
            SomebodyB somebodyB = new SomebodyB("谁");

            somebodyA.SendMessage("解决消息不对称", somebodyB);

            Console.WriteLine("*******************************");

            somebodyB.SendMessage("沟通两个不同的对象，搭建一个第三方平台，实现解耦", somebodyA);


            Console.WriteLine("*******************************");

            Student studentA = new Student("为什么");
            Student studentB = new Student("think&clever");
            Student studentC = new Student("帘外月朦明");
            Student studentD = new Student("采菊花的小百合");
            Student studentE = new Student("风之MX");
            Student studentF = new Student(" 番茄沙司 Melissa(163-番茄-上海)");
            Student studentG = new Student(" 晴月");
            Student studentH = new Student(" 香蕉树上两苹果");



            ChatMediator mediator1 = new ChatMediator(new List<Student>() { studentA, studentB });
            studentA.SendMessage("我今天很开心", mediator1);
            studentB.SendMessage("我今天也很开心", mediator1);
            studentA.SendMessage("这是为什么呢", mediator1);
            studentB.SendMessage("因为我学到了中介者模式，你是为什么呢", mediator1);
            studentA.SendMessage("我是因为上榜了", mediator1);
            studentB.SendMessage("我也上榜了", mediator1);


            ChatMediator mediator2 = new ChatMediator(new List<Student>() { studentA, studentC });

            studentA.SendMessage("我今天很开心", mediator2);
            studentC.SendMessage("我今天也很开心", mediator2);


            Console.WriteLine("**************群聊**************");

            ChatMediator mediator3 = new ChatMediator(new List<Student>() { studentA, studentB, studentC, studentD, studentE, studentF, studentG, studentH });

            studentF.SendMessage("欢迎大家加入高级班", mediator3);

            Console.Read();
        }
    }
}
