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
    public abstract class BaseExepression
    {
        public abstract string Transcate(string word);

        public abstract void TranscateContext(Context context);
    }
}
