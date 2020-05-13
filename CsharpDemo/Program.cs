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
            Bed bed = new Bed("Bed", 1995, 4, "Red", 130, 60, 666);
            bed.GetInfo();
            bed.Wash();
        }
    }
}
