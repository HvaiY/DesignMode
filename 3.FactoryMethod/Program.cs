using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课程");


            Human human2 = new Human();
            human2.ShowKing();
            //IRace human1 = new Human();

            IFactoryMethod humanFactory = new HumanFactory();
            IRace human = humanFactory.CreateInstance();
            human.ShowKing();


            //Five five = new Five();

            IFactoryMethod fiveFactory = new FiveFactory();
            IRace five = fiveFactory.CreateInstance();
            five.ShowKing();


            Console.Read();
        }
    }
}
