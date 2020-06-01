using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    /// <summary>
    /// 1  模板方法设计模式
    /// 2  钩子方法
    /// 3  桥接模式对比
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到软谋教育.net高级班公开课之设计模式特训课，今天是Eleven老师为大家带来的模板方法设计模式");

            //ClientCurrent clientCurrent = new ClientCurrent();
            //clientCurrent.ShowInfo("Adam", "9527");

            //ClientFixed clientFixed = new ClientFixed();
            //clientFixed.ShowInfo("Adam", "9527");

            ClientBase clientCurrent = new ClientCurrent();
            clientCurrent.ShowInfo("Adam", "9527");

            ClientBase clientFixed = new ClientFixed();
            clientFixed.ShowInfo("Adam", "9527");

            ClientBase clientSecret = new ClientSecret();
            clientSecret.ShowInfo("Adam", "9527");
            Console.Read();
        }
    }
}
