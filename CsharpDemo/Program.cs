using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections;

namespace CsharpDemo
{
    class Program
    {
        public delegate double doubleIt(double val);
        static void Main(string[] args)
        {
            // Lambda anonymous function, same as arrow function in js.
            doubleIt dblIt = x => x * 2;
            Console.WriteLine($"5 * 2 = {dblIt(5)}");
        }
    }
}
