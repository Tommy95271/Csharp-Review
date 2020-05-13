using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    abstract class Furniture
    {
        public int Years { get; set; } = 1990;
        public int Legs { get; set; } = 0;
        public string Color { get; set; } = "No Color";
        public double Weight { get; set; } = 0;
        public double Length { get; set; } = 0;
        public double Price { get; set; } = 0;

    }
}
