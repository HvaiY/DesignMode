﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 下端
    /// </summary>
    public class Orc : IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("The king of Orc is Grubby");
        }
    }
}
