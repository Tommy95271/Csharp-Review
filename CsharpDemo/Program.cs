using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DateTime and TimeSpan
            DateTime dateTime = new DateTime(1989, 6, 4);
            Console.WriteLine($"old date: {dateTime}");

            dateTime = dateTime.AddDays(7);
            dateTime = dateTime.AddMonths(3);
            dateTime = dateTime.AddYears(2);
            Console.WriteLine($"new date: {dateTime}");

            TimeSpan workingTime = new TimeSpan(9, 0, 0);
            Console.WriteLine($"Working time: {workingTime}");

            workingTime = workingTime.Subtract(new TimeSpan(1, 0, 0));
            workingTime = workingTime.Add(new TimeSpan(0, 30, 0));
            Console.WriteLine($"Working time: {workingTime}");
            #endregion

            #region Number types
            BigInteger bigNum = BigInteger.Parse("1234512345123451234512345");
            Console.WriteLine($"bigNum * 2 : {bigNum * 2}");
            #endregion

            #region Format
            Console.WriteLine($"Currency : {23.5:c}");
            Console.WriteLine($"Pads with 0: {23:d4}");
            Console.WriteLine($"3 Decimals : {23:f3}");
            Console.WriteLine($"Commas : {2300000:n4}");
            #endregion



        }
    }
}
