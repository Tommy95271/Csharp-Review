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
            #region GetDouble
            //double x = 10;
            //double y = 4;
            //Console.WriteLine($"x + y = {GetDouble(x, y)}");
            //Console.WriteLine($"x is still {x}, y is still {y}");
            #endregion

            #region DoubleIt

            double num = 15; // As you can see, we assign number to num and times except solution.
            double times = 2;
            double solution;
            DoubleIt(num, times, out solution); // So we need to use 'out' param, the usage is simple, put out before the argument.
            Console.WriteLine($"{num} * {times} = {solution}");
            #endregion
        }


        #region helper
        #region DoubleIt
        private static void DoubleIt(double dou, double times, out double solution) // Also before parameter inside function
        {
            solution = dou * times;
        }
        #endregion
        #region GetDouble
        private static double GetDouble(double x=1,double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }
        #endregion

        #endregion

    }
}
