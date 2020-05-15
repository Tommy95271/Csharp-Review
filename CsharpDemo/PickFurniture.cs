using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    public class PickFurniture : Furniture
    {
        public static Furniture GetFurniture(MyEnum myEnum,
            string name = "No Name",
            int years = 0,
            int legs = 0,
            string color = "No Color",
            double weight = 0,
            double length = 0,
            double price = 0)
        {
            if (myEnum == MyEnum.Bed)
            {
                return new Bed(name, years, legs, color, weight, length, price);
            }
            else if (myEnum == MyEnum.Chair)
            {
                return new Chair(name, years, legs, color, weight, length, price);
            }
            else
            {
                return null;
            }
        }
    }
}
