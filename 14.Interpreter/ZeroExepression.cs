using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    /// <summary>
    /// 解析的规则
    /// </summary>
    public class ZeroExepression : BaseExepression
    {
        private static Dictionary<string, string> TranscateDictionary = new Dictionary<string, string>();
        static ZeroExepression()
        {
            TranscateDictionary.Add("1", "1");
            TranscateDictionary.Add("2", "2");
            TranscateDictionary.Add("3", "3");
            TranscateDictionary.Add("4", "4");
            TranscateDictionary.Add("5", "5");
            TranscateDictionary.Add("6", "6");
            TranscateDictionary.Add("7", "7");
            TranscateDictionary.Add("8", "8");
            TranscateDictionary.Add("9", "9");
        }

        public override string Transcate(string word)
        {
            if (TranscateDictionary.ContainsKey(word))
                return TranscateDictionary[word];
            else
                return "0";
        }

        public override void TranscateContext(Context context)
        {
            List<string> sourceTextList = context.SourceText.ToCharArray().Select(w => w.ToString()).ToList();//就是把上下文里面的SourceText按照每个字符转换成一个list的元素

            List<string> result = new List<string>();
            foreach (string word in sourceTextList)
            {
                result.Add(Transcate(word));
            }
            context.SourceText = string.Concat(result);//连接成一个字符串
        }
    }
}
