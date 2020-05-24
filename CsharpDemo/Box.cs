using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    public class Box
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Breadth { get; set; }
        public Box() : this(1, 1, 1) { }
        public Box(int l, int w, int b)
        {
            Length = l;
            Width = w;
            Breadth = b;
        }
    }
}
