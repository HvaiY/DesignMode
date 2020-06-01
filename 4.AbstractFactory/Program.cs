 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 1  简单工厂和工厂方法模式回顾
    /// 2  抽象工厂
    /// 3  抽象工厂的实际应用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到.net高级班公开课程");

            BaseFactory factory = new FrozenThroneFactory();
            IRace human = factory.CreateFirst();
            human.ShowKing();

            BaseFactory sanguoshaFactory = new SanguoshaFactory();
            IRace qun = sanguoshaFactory.CreateFourth();
            qun.ShowKing();

            Console.ReadKey();
        }
    }
}
