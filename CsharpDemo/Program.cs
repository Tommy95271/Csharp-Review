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

            #region String methods
            string randString = "This is a string";
            Console.WriteLine($"Length of the string : {randString.Length}");
            Console.WriteLine($"The string contains 'is' : {randString.Contains("is")}");
            Console.WriteLine($"Index of 'is' : {randString.IndexOf("is")}");
            Console.WriteLine($"The string removes from index 0 to 6 : {randString.Remove(0,6)}");
            Console.WriteLine($"The string replaces 'string' with 'sentence': {randString.Replace("string","sentence")}");
            Console.WriteLine($"The string inserts 'short' to the string : {randString.Insert(10,"short ")}");
            Console.WriteLine($"Comapre A to B : {string.Compare("A","B",StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"Comapre A to a : {string.Compare("A","a",true)}");
            Console.WriteLine($"Comapre A to A : {string.Compare("A","A",true)}");
            #endregion

            #region String methods2
            Console.WriteLine($"A = a : {string.Equals("A","a",StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"Pad Left : {randString.PadLeft(20)}");
            Console.WriteLine($"Pad Right : {randString.PadRight(20)}");
            Console.WriteLine($"Trim white space : {randString.Trim()}");
            Console.WriteLine($"Make string to uppercase : {randString.ToUpper()}");
            Console.WriteLine($"Make string to lowercase : {randString.ToLower()}");
            string newString = string.Format("{0} saw {1} {2} in the {3}.", "Tommy", "cockraochsh", "crying", "wall");
            Console.WriteLine(newString);
            Console.WriteLine($"How to output some special character? Use backslash(\\). Double quotes\", tab\t, enter\n");
            Console.WriteLine(@"This is a verbatim string, which shows exactly what you typed, you don't need escape character\");

            #endregion


        }
    }
}
