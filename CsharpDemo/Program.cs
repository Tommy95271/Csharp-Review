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

            double num = 15; //As you can see, we assign number to num and times except solution.
            double times = 2;
            double solution; //We want to get solution by DoubleIt function, but as the example before,
            DoubleIt(num, times, solution); //We can not get data from another function.
            Console.WriteLine($"{num} * {times} = {solution}");
            #endregion
        }


        #region helper
        #region DoubleIt
        private static void DoubleIt(double dou, double times, double solution)
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
