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
            //double num = 15; // As you can see, we assign number to num and times except solution.
            //double times = 2;
            //double solution;
            //DoubleIt(num, times, out solution); // So we need to use 'out' param, the usage is simple, put out before the argument.
            //Console.WriteLine($"{num} * {times} = {solution}");
            #endregion

            #region Swap
            //int num1 = 10;
            //int num2 = 20;
            //Console.WriteLine($"Before swap, num1 = {num1}, num2 = {num2}");
            //Swap(ref num1, ref num2); // There is another way to change data inside other functions, use 'ref' param.
            //Console.WriteLine($"After swap, num1 = {num1}, num2 = {num2}");
            //// The difference between 'ref' and 'out' is small, since they are all 'Pass by reference', which means you
            //// can not use both of them to make overload functions. The key difference is that you need to initialize the variable
            //// using 'ref' before manipulating it. However, it's opposite for 'out' param, as long as you assign value to 'out'
            //// variable in the end of function, then it'll be ok.'
            #endregion

            #region Param
            // There is a easy way to get all arguments if you don't want know how many arguments you will have.
            // Use 'params' keyword before parameter inside function.'
            // If you've learned Javascript before, then you should be familiar with it, in Javascript it's called 'Rest Operator'.
            // Check this website https://stackoverflow.com/questions/39886700/javascript-spread-syntax-in-c-sharp
            Console.WriteLine($"1 + 2 + 3 = {GetSum(1, 2, 3)}");
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
        private static double GetDouble(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }
        #endregion
        #region Swap
        private static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        #endregion
        #region Param
        static double GetSum(params double[] nums)
        {
            double sum = 0;
            foreach (var n in nums)
            {
                sum += n;
            }
            return sum;
        }
        #endregion
        #endregion

    }
}
