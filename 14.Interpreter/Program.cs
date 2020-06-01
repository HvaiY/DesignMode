using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    /// <summary>
    /// 1 解释器模式
    /// 2 web开发模板替换的解释器模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的解释器模式");
            {
                string text = "abcde";
                long lResult = ToLong(text);
                Console.WriteLine("转换结果是{0}={1}", text, lResult);
            }
            {
                string text = "bcdefg";
                long lResult = ToLong(text);
                Console.WriteLine("转换结果是{0}={1}", text, lResult);
            }
            {
                string text = "cdefghij";
                long lResult = ToLong(text);
                Console.WriteLine("转换结果是{0}={1}", text, lResult);
            }

            {
                string text = "cdefghijkjsdfhjk";
                Context context = new Context(text);
                List<BaseExepression> expressionList = new List<BaseExepression>();
                expressionList.Add(new OtherExepression());
                expressionList.Add(new ZeroExepression());
                foreach (BaseExepression expression in expressionList)
                {
                    expression.TranscateContext(context);
                }


                Console.WriteLine("转换结果是{0}={1}", text, context.GetLongResult());
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 转换规则是 
        /// a到i  对应1到9
        /// 其他的都是0
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static long ToLong(string text)
        {
            long lResult = 0;
            switch (text)
            {
                case "abcde":
                    lResult = 12345;
                    break;
                case "bcdefg":
                    lResult = 234567;
                    break;
                case "cdefghij":
                    lResult = 34567890;
                    break;
                default:
                    throw new Exception("错误的字符串");
            }

            return lResult;
        }

    }
}
