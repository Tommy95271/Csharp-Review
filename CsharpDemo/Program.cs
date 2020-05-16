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
            //ArrayList aList = new ArrayList();
            //aList.Add("Tommy");
            //aList.Add(50);
            //Console.WriteLine($"Number of aList : {aList.Count}");
            //Console.WriteLine($"Capacity of aList : {aList.Capacity}");
            //Console.WriteLine("-------------------------------------");

            //aList.Add(false);
            //aList.Add("Bob");
            //aList.Add(true);
            //Console.WriteLine($"Number of aList : {aList.Count}");
            //Console.WriteLine($"Capacity of aList : {aList.Capacity}");
            //Console.WriteLine("-------------------------------------");

            //ArrayList aList2 = new ArrayList();
            //aList2.AddRange(new object[] { "Jack", "Rose", "Heck" });
            //Console.WriteLine($"Number of aList2 : {aList2.Count}");
            //Console.WriteLine($"Capacity of aList2 : {aList2.Capacity}");
            //Console.WriteLine("-------------------------------------");

            //aList.AddRange(aList2);
            ////aList.Sort(); //You can only call Sort method to number type
            //aList.Reverse();
            //aList.Insert(2, "Turkey");
            //ArrayList range = aList.GetRange(1, 5);
            //foreach (object o in aList)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine("-------------------------------------");

            //foreach (object o in range)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine("-------------------------------------");

            ////aList.Remove("Turkey");
            ////aList.RemoveAt(3);
            ////aList.RemoveRange(1, 5);
            ////foreach (object o in aList)
            ////{
            ////    Console.WriteLine(o);
            ////}
            ////Console.WriteLine("-------------------------------------");
            //// You can remove object, but we comment them in case of problem.

            //Console.WriteLine($"Index of Tommy : {aList.IndexOf("Tommy", 0)}");
            //Console.WriteLine("-------------------------------------");

            //string[] strArr = (string[])aList2.ToArray(typeof(string));
            //try
            //{
            //    foreach (var item in strArr)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
            //Console.WriteLine("-------------------------------------");

            //string[] myArray = { "Dog", "Cat", "Turtle" };
            //ArrayList myArrList = new ArrayList();
            //myArrList.AddRange(myArray);
            //foreach (var o in myArrList)
            //{
            //    Console.WriteLine(o);
            //}
            #endregion
            
            #region Dictionary
            Dictionary<string, int> Books = new Dictionary<string, int>();
            Books.Add("Harry Potter", 100);
            Books.Add("Bible", 1);
            Books.Add("Text Book", 500);
            Books.Remove("Bible");
            Console.WriteLine($"How many books do you have? {Books.Count}");
            #endregion
        }
    }
}
