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
            double x = 10;
            double y = 4;
            Console.WriteLine($"x + y = {GetDouble(x,y)}");
            Console.WriteLine($"x is still {x}, y is still {y}");

        }
        private static double GetDouble(double x=1,double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }
    }
}
