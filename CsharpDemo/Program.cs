﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bed bed = new Bed();
            bed.GetInfo();
            bed.Name = "Bed";
            bed.Legs = 4;
        }
    }
}
