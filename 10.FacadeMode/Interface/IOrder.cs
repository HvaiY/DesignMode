﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode.Interface
{
    public interface IOrder
    {
        bool Check(int commodityId);
    }
}
