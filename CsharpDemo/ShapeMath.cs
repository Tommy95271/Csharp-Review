using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    // Static class means you can access everything inside static class without needing to create an instance,.
    public static class ShapeMath
    {
        public static double GetArea(string shape = "", double length1 = 0, double length2 = 0)
        {
            if (string.Equals(shape, "Rectangle", StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2;
            }
            else if (string.Equals(shape, "Triangle", StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2 / 2;
            }
            else if (string.Equals(shape, "Circle", StringComparison.OrdinalIgnoreCase))
            {
                return Math.PI * Math.Pow(length1, 2);
            }
            else { return -1; }
        }

    }
}
