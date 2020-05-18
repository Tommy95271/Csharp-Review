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
            #region Lambda
            //// Lambda anonymous function, same as arrow function in js.
            //doubleIt dblIt = x => x * 2;
            //Console.WriteLine($"5 * 2 = {dblIt(5)}");
            #endregion

            #region LINQ
            // LINQ extension
            //List<int> numList = new List<int>() { 2, 8, 7, 54, 87 };
            //var evenList = numList.Where(x => x % 2 == 0).ToList();
            //foreach (var i in evenList)
            //{
            //    Console.WriteLine($"Even number is : {i}");
            //}
            //Console.WriteLine("-------------------------------------");

            //var rangeList = numList.Where(x => (x > 2) && (x < 9)).ToList();
            //foreach (var i in rangeList)
            //{
            //    Console.WriteLine($"Range number is : {i}");
            //}
            //Console.WriteLine("-------------------------------------");
            #endregion

            #region FlipCoin
            //List<int> coinList = new List<int>();
            //int i = 0;
            //Random rnd = new Random();
            //while (i < 100)
            //{
            //    coinList.Add(rnd.Next(1, 3));
            //    i++;
            //}
            //Console.WriteLine($"Heads is : {coinList.Where(x => x == 1).ToList().Count}");
            //Console.WriteLine($"Tails is : {coinList.Where(x => x == 2).ToList().Count}");
            //Console.WriteLine("-------------------------------------");
            #endregion

            #region StartsWith
            //List<string> nameList = new List<string>() { "Tommy","Sally","Smith"};
            //var sList = nameList.Where(x => x.StartsWith("s",StringComparison.OrdinalIgnoreCase));

            //foreach (var s in sList)
            //{
            //    Console.WriteLine($"Names stars with s {s}");
            //}
            //Console.WriteLine("-------------------------------------");
            #endregion

            #region Select
            //var oneToten = new List<int>(Enumerable.Range(1, 10));
            //var squareList = oneToten.Select(x => x * x);
            //foreach (var s in squareList)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region Zip
            List<int> list1 = new List<int>() { 1, 3, 5 };
            List<int> list2 = new List<int>() { 65, 5, 9 };
            var sumList = list1.Zip(list2, (x, y) => x + y);
            foreach (var s in sumList)
            {
                Console.WriteLine($"The sum of each item in list1 and list2 is : {s}");
            }
            #endregion
        }
    }
}
