using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 1 观察者模式Observer
    /// 2 .net的委托事件
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课之设计模式特训课，今天是Eleven老师为大家带来的观察者模式");
            Baby bady = new Baby();
            bady.Cry();



            Console.WriteLine("*************new Cry******************");
            bady.AddObserver(new Father());
            bady.AddObserver(new Mother());
            bady.AddObserver(new Dog());
            bady.AddObserver(new Cat());
            bady.AddObserver(new Mouse());

            bady.AddObserver(new Neighbor());


            bady.NewCry();

            Console.WriteLine("*************Cry event******************");
            bady.BabyCryHandler += new Father().Roar;
            bady.BabyCryHandler += new Mother().Whisper;
            bady.BabyCryHandler += new Dog().Bark;
            bady.BabyCryHandler += new Cat().Run;
            bady.BabyCryHandler += new Mouse().Hide;
            bady.BabyCryHandler += new Neighbor().Awake;


            bady.CryEvent();


            Action<string, int, DateTime> action = new Action<string, int, DateTime>(Test);
            action("天天", 11, DateTime.Now);

            //Func

            Console.ReadKey();
        }

        private static void Test(string name, int id, DateTime now)
        { }
    }
}
