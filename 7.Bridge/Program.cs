using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课程，这里是Eleven为大家带来的设计模式特训课");

            //BasePhone applePhone = new IPhone();
            //applePhone.Call();
            //applePhone.Message();


            //BasePhone applePhoneAndroid = new IPhoneAndroid();
            //applePhoneAndroid.Call();
            //applePhoneAndroid.Message();

            //BasePhone sumsong = new Sumsong();
            //sumsong.Call();
            //sumsong.Message();


            //BasePhone sumsongIOS = new SumsongIOS();
            //sumsongIOS.Call();
            //sumsongIOS.Message();

            BasePhone lumia = new Lumia();
            lumia.CurrentSystem = new IOSSystem();
            lumia.Message();
            lumia.Call();

            BasePhone xiaomi = new Xiaomi();
            xiaomi.CurrentSystem = new WinphoneSystem();
            xiaomi.Message();
            xiaomi.Call();

            Console.Read();
        }
    }
}
