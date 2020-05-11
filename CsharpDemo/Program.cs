using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CsharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(4),new Rectangle(5,7) };
            foreach (Shape s in shapes)
            {
                Console.WriteLine($"The Area of {s.Name} is {s.Area()}");
                s.GetInfo();
            }

        }
    }
}
