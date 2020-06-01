﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    /// <summary>
    /// 法师
    /// </summary>
    public class Mage : CharactorBase
    {

        public override void Show()
        {
            Console.WriteLine("这里是法师 Oye");
        }
    }

    //五件套  头  胸甲  肩膀  手套  裤子

    /// <summary>
    /// 使用继承的时候，是在编译期就确定了功能
    /// </summary>
    public class MageWithHead : Mage
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("带上凌风头");
        }
    }
}
