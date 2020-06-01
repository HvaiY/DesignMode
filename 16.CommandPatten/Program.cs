using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatten
{
    /// <summary>
    /// 1 命令模式介绍和例子
    /// 2 和委托的对比
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课之设计模式特训课，今天是Eleven老师为大家带来的命令模式");
            Document doc = new Document()
            {
                Id = 11,
                Name = "高级班vip课程介绍",
                Content = ".net高级班6月初开学，火热报名中",
                CreateTime = DateTime.Now
            };

            //doc.Read();
            //doc.Write();

            BaseReceiver reveiver = new ReadReceiver();
            reveiver.Execute(doc);


            BaseCommand command = new ReadCommand();
            //command.SetReceiver(reveiver);//指定处理人
            command.Execute(doc);

            Invoker invoker = new Invoker(command);
            invoker.Execute(doc);


            Console.Read();
        }
    }
}
