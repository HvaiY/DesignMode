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
    public class OtherExepression : BaseExepression
    {
        private static Dictionary<string, string> TranscateDictionary = new Dictionary<string, string>();
        static OtherExepression()
        {
            TranscateDictionary.Add("a", "1");
            TranscateDictionary.Add("b", "2");
            TranscateDictionary.Add("c", "3");
            TranscateDictionary.Add("d", "4");
            TranscateDictionary.Add("e", "5");
            TranscateDictionary.Add("f", "6");
            TranscateDictionary.Add("g", "7");
            TranscateDictionary.Add("h", "8");
            TranscateDictionary.Add("i", "9");
        }

        public override string Transcate(string word)
        {
            if (TranscateDictionary.ContainsKey(word))
                return TranscateDictionary[word];
            else
                return word;
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
