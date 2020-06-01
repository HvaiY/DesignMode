using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    /// <summary>
    /// 上下文
    /// </summary>
    public class Context
    {
        public Context(string sourceText)
        {
            SourceText = sourceText;
        }

        public string SourceText { get; set; }


        //public long LongResult { get; set; }

        public long GetLongResult()
        {
            return long.Parse(SourceText);
        }
    }
}
