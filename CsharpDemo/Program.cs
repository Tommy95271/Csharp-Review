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

            // LINQ extension
            List<int> numList = new List<int>() { 2, 8, 7, 54, 87 };
            var evenList = numList.Where(x => x % 2 == 0).ToList();
            foreach (var i in evenList)
            {
                Console.WriteLine($"Even number is : {i}");
            }
            Console.WriteLine("-------------------------------------");

            var rangeList = numList.Where(x => (x > 2) && (x < 9)).ToList();
            foreach (var i in rangeList)
            {
                Console.WriteLine($"Range number is : {i}");
            }
            Console.WriteLine("-------------------------------------");



        }
    }
}
