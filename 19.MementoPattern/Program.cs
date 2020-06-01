using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 1 备忘录模式(Memento Patern)，一次恢复和多次恢复
    /// 2 备忘模式和命令模式的不同区别
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课之设计模式特训课，这里是Eleven老师为大家带来的备忘录模式");

            Manager manager = new Manager();

            War3 game = new War3(army: "6只食尸鬼", race: "Undead", hero: "死亡骑士 1级", resource: "1000G 500W");//命名参数  
            game.Show();

            manager.Save("刚开始", new War3(army: "6只食尸鬼", race: "Undead", hero: "死亡骑士 1级", resource: "1000G 500W"));

            ////存档一下
            //MementoData memento = new MementoData(new War3(army: "6只食尸鬼", race: "Undead", hero: "死亡骑士 1级", resource: "1000G 500W"));//重新new一个对象

            Console.WriteLine("去小怪点MF");
            Thread.Sleep(1000 * 5);
            Console.WriteLine("*******************************************************");
            game.Hero = "死亡骑士 2级";
            game.Army = "6只食尸鬼 2只蜘蛛";
            game.Resource = "2000G 100W";
            game.Show();

            manager.Save("去小怪点MF", new War3(army: "6只食尸鬼 2只蜘蛛", race: "Undead", hero: "死亡骑士 2级", resource: "2000G 100W"));


            Console.WriteLine("大决战之前");
            Thread.Sleep(1000 * 5);
            Console.WriteLine("*******************************************************");
            game.Hero = "死亡骑士 5级   巫妖 3级  小强 1级";
            game.Army = "3只食尸鬼 8只蜘蛛 2只憎恶 1只雕像";
            game.Resource = "200G 2000W";
            game.Show();

            manager.Save("大决战之前", new War3(army: "3只食尸鬼 8只蜘蛛 2只憎恶 1只雕像", race: "Undead", hero: "死亡骑士 5级   巫妖 3级  小强 1级", resource: "200G 2000W"));

            Console.WriteLine("决战之后：失败");
            Thread.Sleep(1000 * 5);
            Console.WriteLine("*******************************************************");
            game.Hero = "死亡骑士 6级";
            game.Army = "3只食尸鬼 2只蜘蛛";
            game.Resource = "500G 2000W";
            game.Show();

            Console.WriteLine("*******************************************************");
            Console.WriteLine("恢复存档");

            manager.Recover("大决战之前").Show();
            manager.Recover("去小怪点MF").Show();
            manager.Recover("刚开始").Show();
            //War3 gameNew = memento.Recover();
            //gameNew.Show();

            //111111111111

            Console.Read();
        }
    }
}
