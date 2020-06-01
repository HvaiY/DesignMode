using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 人族  暗夜  兽族  不死
    /// 魏    蜀    吴    群
    /// </summary>
    public abstract class BaseFactory
    {
        public abstract IRace CreateFirst();
        public abstract IRace CreateSecond();
        public abstract IRace CreateThird();
        public abstract IRace CreateFourth();

        //public abstract IRace CreateFifth();
    }
}
