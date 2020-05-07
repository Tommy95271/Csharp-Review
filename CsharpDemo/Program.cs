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
            string[,] multiArr = new string[2, 2] { { "god","evil"},{"food","drink" } };
            Console.WriteLine(multiArr[1, 1]);

            for (int i = 0; i < multiArr.GetLength(0); i++)
            {
                for (int j = 0; j < multiArr.GetLength(1); j++)
                {
                    Console.WriteLine($"Output the items one by one : {i} {j} {multiArr[i,j]}");
                }
            }

            #endregion
            Console.ReadLine();

        }
    }
}
