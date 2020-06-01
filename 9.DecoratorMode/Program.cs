using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    /// <summary>
    /// 装饰器模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课程，今天是设计模式特训课之装饰器模式");

            //CharactorBase mage = new Mage();
            //mage.Show();

            //CharactorBase mageWithHead = new MageWithHead();
            //mageWithHead.Show();
            Console.WriteLine("*******************************************");
            CharactorBase mage = new Mage();//造一个法师
            mage.Show();


            Console.WriteLine("*******************************************");
            mage = new CharactorDecoratorHead(mage);
            mage.Show();

            Console.WriteLine("*******************************************");
            mage = new CharactorDecoratorShoulder(mage);
            mage.Show();


            Console.WriteLine("*******************************************");
            mage = new CharactorDecoratorCuirass(mage);
            mage = new CharactorDecoratorTrousers(mage);
            mage.Show();

            Console.Read();
        }
    }
}
