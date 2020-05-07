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
            StringBuilder sb = new StringBuilder("This is a sentence");
            StringBuilder sb2 = new StringBuilder("This is a more important sentence", 256);
            Console.WriteLine($"Capacity : {sb.Capacity}\nCapacity : {sb2.Capacity}");
            Console.WriteLine($"Length : {sb.Length}");

            sb2.AppendLine("\nMore important sentence");
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            string goodMan = "Tommy";
            sb2.AppendFormat(enUS, $"Good Man {goodMan}");
            Console.WriteLine(sb2.ToString());

        }
    }
}
