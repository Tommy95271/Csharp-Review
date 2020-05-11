using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Rectangle : Shape
    {
        public double Width { get; set; } = 0;
        public double Length { get; set; } = 0;

        public Rectangle(double width, double length)
        {
            Name = "Rectangle";
            Width = width;
            Length = length;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a Length of {Length} and Width of {Width}");
        }

        public override double Area()
        {
            return Width * Length;
        }
    }
}
