using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    /// <summary>
    /// 
    /// </summary>
    public class CharactorDecoratorHead : CharactorDecoratorBase
    {
        public CharactorDecoratorHead(CharactorBase charactor)
            : base(charactor)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Show()
        {
            base.Show();
            Console.WriteLine("带上凌风头盔");
        }
    }
}
