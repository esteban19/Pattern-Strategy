﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Multiply:IStrategy
    {
        public int arithmetic(int a, int b)
        {
            return a * b;
        }
    }
}
