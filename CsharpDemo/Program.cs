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
        static void Main(string[] args)
        {
            #region ArrayList
            ArrayList aList = new ArrayList();
            aList.Add("Tommy");
            aList.Add(50);

            Console.WriteLine($"Number of aList : {aList.Count}");
            Console.WriteLine($"Capacity of aList : {aList.Capacity}");

            aList.Add(false);
            aList.Add("Bob");
            aList.Add(true);

            Console.WriteLine($"Number of aList : {aList.Count}");
            Console.WriteLine($"Capacity of aList : {aList.Capacity}");
            #endregion

        }
    }
}
