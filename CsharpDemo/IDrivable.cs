﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; }
        void Drive();
        void Stop();
    }
}
