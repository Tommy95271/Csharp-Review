﻿using System;
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
            //Animal fox = new Animal("fox", "whaa");
            //fox.MakeSound();
            //// The function belongs to class Animal instead of every instance now, so everytime a instance is created
            //// the numOfAnimals will plus one, and GetNumAnimals will return it.
            //Console.WriteLine($"Number of Animals is : {Animal.GetNumAnimals()}");
            //Animal noName = new Animal("dog");
            //noName.MakeSound();
            //Console.WriteLine($"Number of Animals is : {Animal.GetNumAnimals()}");
            #endregion

            #region Class with prop and constructor
            Animal2 dog = new Animal2();

            // Call the setter
            dog.SetName("Ahfu");

            // Set the property, see the difference?
            dog.Sound = "Woon";
            Console.WriteLine($"The dog is named {dog.GetName()} and says {dog.Sound}");

            // Test auto generated getters and setters
            dog.Owner = "Tommy";
            Console.WriteLine($"{dog.GetName()} owner is {dog.Owner}");

            // Get the read-only id number
            Console.WriteLine($"Shelter ID is {dog.idNum}");

            // Test static property
            Console.WriteLine($"Number of animals is {Animal2.NumOfAnimals}");

            Animal2 cat = new Animal2();
            Console.WriteLine(cat.Sound);
            Console.WriteLine($"Number of animals is {Animal2.NumOfAnimals}");

            Console.ReadLine();
            #endregion

            #region Static Class
            // We don't create an instance here but we can use the method inside it.
            //Console.WriteLine($"The area of your rectangle is : {ShapeMath.GetArea("rectangle", 3, 5)}");
            //Console.WriteLine($"The area of your circle is : {ShapeMath.GetArea("circle", 3, 5)}");
            //Console.WriteLine($"The area of your triangle is : {ShapeMath.GetArea("triangle", 3, 5)}");
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
