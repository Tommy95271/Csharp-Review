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
            Console.WriteLine("This is not a Circle nor a Rectangle");
        }

        public override double Area()
        {
            return Width * Length;
        }
    }
}
