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
            Bed bed = new Bed("Bed", 1995, 4, "Red", 130, 60, 666);
            bed.GetInfo();
            bed.Wash();

            Furniture bed2 = PickFurniture.GetFurniture(MyEnum.Bed, "Good bed", 2005, 4, "Black", 150, 70, 19000);
            bed2.GetInfo();

            CleanTools cleanTools = new CleanTools(bed2, true);
            cleanTools.Clean();
        }
    }
}
