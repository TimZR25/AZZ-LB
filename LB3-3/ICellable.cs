﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_3
{
    internal interface ICellable
    {
        public string GetSign();

        enum Direction { Left, Right, Up, Down }
    }
}