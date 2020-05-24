﻿using System;
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
        public delegate double doubleIt(double val);
        static void Main(string[] args)
        {
            #region AnimalFarm as Array
            //AnimalFarm myAnimals = new AnimalFarm();
            //myAnimals[0] = new Animal("Tommy");
            //myAnimals[1] = new Animal("May");
            //myAnimals[2] = new Animal("Hami");
            //myAnimals[3] = new Animal("Luke");
            //foreach (Animal animal in myAnimals)
            //{
            //    Console.WriteLine(animal.Name);
            //}

            //Console.WriteLine($"How many animals do you have : {myAnimals.Count}");

            //Console.ReadLine();
            #endregion

            #region Box
            Box box1 = new Box(4, 6, 7);
            Box box2 = new Box(7, 8, 9);
            Box box3 = box1 + box2;
            Console.WriteLine($"box3 : {box3}");
            Box box4 = box2 - box1;
            Console.WriteLine($"box4 : {box4}");
            Console.WriteLine("------------------------------");

            Box box5 = new Box(4, 6, 7);
            Console.WriteLine($"Are Length and Width and Breadth of box5 == box1 ? {box5 == box1}");
            Console.WriteLine($"Are Length and Width and Breadth of box5 != box4 ? {box5 != box4}");
            Console.WriteLine("------------------------------");

            Console.WriteLine($"int box2 : {(int)box2}");
            Console.WriteLine("------------------------------");

            Console.WriteLine($"Box 3 : {(Box)3}");
            #endregion
        }
    }
}
