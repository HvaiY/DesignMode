using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 1 策略模式(Strategy)介绍和优缺点
    /// 2 策略模式和简单工厂的结合
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎来到软谋教育.net高级班公开课之设计模式特训课，今天是Eleven老师为大家带来的策略模式");
            bool isGoon = true;

            while (isGoon)
            {
                Console.WriteLine("请输入第一个数字:");
                string sInput1 = Console.ReadLine();
                Console.WriteLine("请输入+-*/:");
                string sOperate = Console.ReadLine();
                Console.WriteLine("请输入第二个数字:");
                string sInput2 = Console.ReadLine();
                int iInput1 = 0;
                int iInput2 = 0;
                if (!int.TryParse(sInput1, out iInput1) || !int.TryParse(sInput2, out iInput2))
                {
                    Console.WriteLine("请输入有效数字");
                    continue;
                }
                //检测0
                int result = 0;
                //switch (sOperate)//业务逻辑和算法混合在一起去了
                //{
                //    case "+":
                //        result = iInput1 + iInput2;
                //        break;
                //    case "-":
                //        result = iInput1 - iInput2;
                //        break;
                //    case "*":
                //        result = iInput1 * iInput2;
                //        break;
                //    case "/":
                           //检测0 
                //        result = iInput1 / iInput2;
                //        break;
                //    default:
                //        {
                //            Console.WriteLine("操作符号异常");
                //            continue;
                //        }
                //}


                //switch (sOperate)//业务逻辑和算法分开
                //{
                //    case "+":
                //        {
                //            BaseStrategy strategy = new PlusStrategy();
                //            strategy.LeftInput = iInput1;
                //            strategy.RightInput = iInput2;
                //            result = strategy.Calculation();
                //        }
                //        break;
                //    case "-":
                //        {
                //            BaseStrategy strategy = new MinusStrategy();
                //            strategy.LeftInput = iInput1;
                //            strategy.RightInput = iInput2;
                //            result = strategy.Calculation();
                //        }
                //        break;
                //    case "*":
                //        {
                //            BaseStrategy strategy = new MutiplyStrategy();
                //            strategy.LeftInput = iInput1;
                //            strategy.RightInput = iInput2;
                //            result = strategy.Calculation();
                //        }
                //        break;
                //    case "/":
                //        {
                //            BaseStrategy strategy = new DivisionStrategy();
                //            strategy.LeftInput = iInput1;
                //            strategy.RightInput = iInput2;
                //            result = strategy.Calculation();
                //        }
                //        break;
                //    default:
                //        {
                //            Console.WriteLine("操作符号异常");
                //            continue;
                //        }
                //}

                //switch (sOperate)//引入context  1 可以添加额外处理  2为计算准备一些客户端不需要知道的数据
                //{
                //    case "+":
                //        {
                //            BaseStrategy strategy = new PlusStrategy();
                //            Context context = new Context(strategy);
                //            result = context.Calculation(iInput1,iInput2);
                //        }
                //        break;
                //    case "-":
                //        {
                //            BaseStrategy strategy = new MinusStrategy();
                //            Context context = new Context(strategy);
                //            result = context.Calculation(iInput1, iInput2);
                //        }
                //        break;
                //    case "*":
                //        {
                //            BaseStrategy strategy = new MutiplyStrategy();
                //            Context context = new Context(strategy);
                //            result = context.Calculation(iInput1, iInput2);
                //        }
                //        break;
                //    case "/":
                //        {
                //            BaseStrategy strategy = new DivisionStrategy();
                //            Context context = new Context(strategy);
                //            result = context.Calculation(iInput1, iInput2);
                //        }
                //        break;
                //    default:
                //        {
                //            Console.WriteLine("操作符号异常");
                //            continue;
                //        }
                //}//上端必须知道所有的算法，并负责选择算法


                
                //不需要知道算法  也不负责选择   职责交给简单工厂
                BaseStrategy strategy = SimpleFactory.CreateInstance(sOperate);
                Context context = new Context(strategy);
                result = context.Calculation(iInput1, iInput2);

                
                Console.WriteLine("{0}{1}{2}={3}", iInput1, sOperate, iInput2, result);
            }


            Console.Read();
        }
    }
}
