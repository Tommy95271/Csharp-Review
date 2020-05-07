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
            #region Explicity array
            int[] arr = new int[3];
            arr[1] = 3;
            Console.WriteLine($"index 0 of arr is : {arr[0]}");
            Console.WriteLine($"index 1 of arr is : {arr[1]}");
            #endregion

            #region Implicity array
            //Because object is the very base of every data.
            object[] newArr = { 4, "good", 6.5 };
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine($"Index {i}. Value : {newArr[i]}." +
                    $" Type : {newArr[i].GetType()}. newArr type : {newArr.GetType()}");
            }
            #endregion

            #region Multiple arrays
            //In multiple arrays, first number stands for vertical columns, seconde stands for horizontal rows
            string[,] multiArr = new string[2, 2] { { "god", "evil" }, { "food", "drink" } };
            Console.WriteLine(multiArr[1, 1]);

            for (int i = 0; i < multiArr.GetLength(0); i++)
            {
                for (int j = 0; j < multiArr.GetLength(1); j++)
                {
                    Console.WriteLine($"Output the items one by one : {i} {j} {multiArr[i,j]}");
                }
            }
            string[,] coolArr = { { "Mary", "Tom", "Vincen", "Josh" }, { "eating", "crying", "drinking", "sitting" } };
            PrintArray(coolArr, "Foreach");
            #endregion

            #region Number array
            int[] numArr = { 1, 5, 54, 3, 7 };
            Console.WriteLine($"Index of 5 : {Array.IndexOf(numArr, 5)}");
            Array.Sort(numArr);
            Array.Reverse(numArr);
            Console.WriteLine("Set index 1 of numArr to 0");
            numArr.SetValue(0, 1);
            PrintArray(numArr, "arr");

            int[] srcArr = { 1, 2, 3 };
            int[] desArr = new int[2];
            int startInd = 0;
            int len = 2;
            Array.Copy(srcArr, startInd, desArr, startInd, len);
            PrintArray(desArr,"copy");

            Array anotherArr = Array.CreateInstance(typeof(int), 10);
            srcArr.CopyTo(anotherArr, 6);
            //Because we can't transform Array to int, so we can't use PrintArray function, unless we create another function.
            foreach (var k in anotherArr)
            {
                Console.WriteLine($"Copy to : {k}");
            }

            int[] numArray = { 2, 11, 33 };
            Console.WriteLine($"> 10 : {Array.Find(numArray,GT10)}");
            Console.WriteLine($"> 10 : {Array.FindAll(numArray,GT10)}");
            Console.WriteLine($"> 10 : {Array.FindIndex(numArray,GT10)}");

            #endregion

            Console.ReadLine();

        }

        private static bool GT10(int n)
        {
            return n > 10;
        }
        #region helper
        private static void PrintArray(int[] coolArr, string msg)
        {
            foreach (var m in coolArr)
            {
                Console.WriteLine($"{msg} : {m}");
            }
        }

        private static void PrintArray(string[,] coolArr, string msg)
        {
            foreach (var m in coolArr)
            {
                Console.WriteLine($"{msg} : {m}");
            }
        }
        #endregion

    }
}
