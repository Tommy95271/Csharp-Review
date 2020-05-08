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
            #region Struct
            // A small example of struct
            //Rectangle rec1 = new Rectangle(100, 40);
            //Rectangle rec2 = rec1;
            //Rectangle rec3 = new Rectangle();
            //Console.WriteLine($"Area of rec1 = {rec1.Area()}");
            //rec1.length = 50;
            //Console.WriteLine($"Area of rec1 = {rec1.Area()}");
            //Console.WriteLine($"Length of rec2 = {rec2.length}");
            //Console.WriteLine(rec3.width);
            #endregion

            #region Class
            Anamal fox = new Anamal("fox", "whaa");
            fox.MakeSound();
            // The function belongs to class Animal instead of every instance now, so everytime a instance is created
            // the numOfAnimals will plus one, and .
            Console.WriteLine($"Number of Animals is : {Anamal.GetNumAnimals()}");
            Anamal noName = new Anamal("dog");
            noName.MakeSound();
            Console.WriteLine($"Number of Animals is : {Anamal.GetNumAnimals()}");
            #endregion
        }
    }

    #region helper
    #region Struct
    public struct Rectangle
    {
        // You can't assign data to property, try it.
        public double length { get; set; }
        public double width { get; set; }
        // You can give fallback data to constructor but it won't work, because if you create a struct without arguments,
        // it will call the default constructor, which is 0.
        // In the example in main, rec3 is created without arguments, so the properties inside it are all 0.
        public Rectangle(double l = 10, double w = 14)
        {
            length = l;
            width = w;
        }
        public double Area()
        {
            return length * width;
        }
    }
    #endregion

    #endregion

}
