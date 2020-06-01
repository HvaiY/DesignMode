using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 上端
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课程");

            Human human2 = new Human();
            human2.ShowKing();

            IRace human1 = new Human();
            
            IRace human = Factory.CreateInstance(Factory.RaceType.Human);
            human.ShowKing();

            //Orc orc = new Orc();
            //IRace orc = new Orc();
            IRace orc = Factory.CreateInstance(Factory.RaceType.Orc);
            orc.ShowKing();

            IRace undead = Factory.CreateInstance(Factory.RaceType.Undead);
            undead.ShowKing();

            Console.WriteLine("*********************CreateInstanceConfig**********************");
            IRace iRace = Factory.CreateInstanceConfig();
            iRace.ShowKing();



            Console.WriteLine("*********************CreateInstanceReflect**********************");
            IRace iRace2 = Factory.CreateInstanceReflect();
            iRace2.ShowKing();
            Console.Read();

        }
    }
}
