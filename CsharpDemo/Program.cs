using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Args {i} : {args[i]}");
            }

            string[] strArr = Environment.GetCommandLineArgs();
            Console.WriteLine(string.Join(", ", strArr));

            Console.ReadLine();
        }
    }
}
