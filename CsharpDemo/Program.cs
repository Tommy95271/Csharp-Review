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
            Warrior Bob = new Warrior("Bob",1000,120,34);
            Warrior Ted = new Warrior("Ted",1000,120,43);
            Battle.StartFight(Bob, Ted);
        }
    }
}
