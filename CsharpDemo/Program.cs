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
            //Bed bed = new Bed("Bed", 1995, 4, "Red", 130, 60, 666);
            //bed.GetInfo();
            //bed.Wash();

            Console.WriteLine("-------------------------------");
            Furniture bed2 = PickFurniture.GetFurniture(MyEnum.Bed);
            //bed2.GetInfo();

            CleanTools cleanTools = new CleanTools(bed2, true, "Good Bed", 1989, 4, "Red", 250, 64, 1989);
            cleanTools.Clean();
            cleanTools.GetInfo();

            Console.WriteLine("-------------------------------");
            Furniture chair = PickFurniture.GetFurniture(MyEnum.Chair);
            cleanTools = new CleanTools(chair, false, "Blood chair", 1991, 6, "Yellow", 64, 64, 999);
            cleanTools.Clean();
            cleanTools.GetInfo();
            Console.ReadLine();
        }
    }
}
