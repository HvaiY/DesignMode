﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterShow
{
    public interface ISqlHelper
    {
        void Add();
        void Delete();
        void Update();
        void Search();

    }
}
