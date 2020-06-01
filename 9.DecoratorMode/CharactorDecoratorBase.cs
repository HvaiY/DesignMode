using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    /// <summary>
    /// 装饰器的基类
    /// </summary>
    public class CharactorDecoratorBase : CharactorBase
    {
        protected CharactorBase Charactor;
        public CharactorDecoratorBase(CharactorBase charactor)
        {
            this.Charactor = charactor;
        }


        public override void Show()
        {
            this.Charactor.Show();
            Console.WriteLine("给角色动态的换装备");
        }
    }
}
