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
            Shape[] shapes = { new Circle(4), new Rectangle(5, 7) };
            foreach (Shape s in shapes)
            {
                Console.WriteLine($"The Area of {s.Name} is {s.Area():f2}");
                s.GetInfo();
                Circle testCric = s as Circle;
                if (testCric == null)
                {
                    Console.WriteLine("This is not a Circle");
                }
                if (s is Circle)
                {
                    Console.WriteLine("This is not a Rectangle\n");
                }
            }
            Console.WriteLine();
            object cir1 = new Circle(5);
            Circle cir2 = (Circle)cir1;
            Console.WriteLine($"{cir2.Name} Area : {cir2.Area():f2}");
            Console.WriteLine(cir2.GetType());
        }
    }
}
