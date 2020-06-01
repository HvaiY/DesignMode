using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 1 状态模式(State)介绍和使用
    /// 2 状态模式好处和实际的应用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课之设计模式特训课，今天是Eleven老师为大家带来的状态模式");


            Context context = new Context(new GreenLight());//最开始准备一个绿灯
            context.Change();
            context.Change();
            context.Change();
            context.Change();
            context.Change();
            context.Change();


            //Light light = new Light(LightState.Green);
            ////绿  黄   红  绿  黄   红 
            //light.Change();
            //light.Change();
            //light.Change();
            //light.Change();
            //light.Change();
            //light.Change();



            //if (light.State == LightState.Green)
            //{
            //    light.SetYellow();
            //}
            //else if (light.State == LightState.Yellow)
            //{
            //    light.SetRed();
            //}
            //else if (light.State == LightState.Red)
            //{
            //    light.SetGreen();
            //}


            //light.Change();
            //if (light.State == LightState.Green)
            //{
            //    light.SetYellow();
            //}
            //else if (light.State == LightState.Yellow)
            //{
            //    light.SetRed();
            //}
            //else if (light.State == LightState.Red)
            //{
            //    light.SetGreen();
            //}

            //light.Change();
            //if (light.State == LightState.Green)
            //{
            //    light.SetYellow();
            //}
            //else if (light.State == LightState.Yellow)
            //{
            //    light.SetRed();
            //}
            //else if (light.State == LightState.Red)
            //{
            //    light.SetGreen();
            //}
            Console.Read();
        }
    }
}
