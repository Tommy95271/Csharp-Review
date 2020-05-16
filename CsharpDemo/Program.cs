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
            #region List<Animal>
            //List<Animal> animalList = new List<Animal>();
            //Animal target = new Animal("Jessica");
            //Animal target2 = new Animal("Beyonce");
            //animalList.Add(new Animal("Doad"));
            //animalList.Add(new Animal("Jess"));
            //animalList.Add(target);
            //animalList.Add(new Animal("Beca"));
            //animalList.Insert(1, new Animal() { Name = "Koe" });
            //foreach (var o in animalList)
            //{
            //    Console.WriteLine(o.Name);
            //}
            //Console.WriteLine("------------------------------");

            //animalList.Remove(target);
            //foreach (var o in animalList)
            //{
            //    Console.WriteLine(o.Name);
            //}
            //Console.WriteLine("------------------------------");

            //animalList.Add(target2);
            //Console.WriteLine($"Does animalList contain Beyonce? {animalList.Contains(target2)}");
            //Console.WriteLine("------------------------------");

            //Console.WriteLine($"How many animals are in animalList? {animalList.Count()}");
            //Console.WriteLine($"How many animals are in animalList? {animalList.Count}");
            //Console.WriteLine("------------------------------");
            #endregion

            #region GetSum()
            //int x = 5; int y = 4;
            //Animal.GetSum(ref x, ref y);
            //Console.WriteLine("------------------------------");

            //string strX = "5"; string strY = "4";
            //Animal.GetSum(ref strX, ref strY);
            //Console.WriteLine("------------------------------");
            #endregion

            #region Rectangle
            //Rectangle<int> rec1 = new Rectangle<int>(20, 40);
            //Console.WriteLine(rec1.GetArea());
            //Rectangle<string> rec2 = new Rectangle<string>("20", "40");
            //Console.WriteLine(rec2.GetArea());
            #endregion

        }
        //public struct Rectangle<T>
        //{
        //    private T width;
        //    private T length;
        //    public T Width
        //    {
        //        get { return width; }
        //        set { width = value; }
        //    }
        //    public T Length
        //    {
        //        get { return length; }
        //        set { length = value; }
        //    }
        //    public Rectangle(T w, T l)
        //    {
        //        width = w;
        //        length = l;
        //    }
        //    public string GetArea()
        //    {
        //        double dblWidth = Convert.ToDouble(Width);
        //        double dblLength = Convert.ToDouble(Length);
        //        return string.Format($"{Width} * {Length} = {dblWidth * dblLength}"); 
        //    }
        //}
    }
}
