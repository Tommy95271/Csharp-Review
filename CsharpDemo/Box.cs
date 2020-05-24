using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    public class Box
    {
        /// <summary>
        /// Add props and constructors
        /// </summary>
        public int Length { get; set; }
        public int Width { get; set; }
        public int Breadth { get; set; }
        public Box() : this(1, 1, 1) { }
        public Box(int l, int w, int b)
        {
            Length = l;
            Width = w;
            Breadth = b;
        }
        /// <summary>
        /// Override operator + in Box, remember to use static modifier.
        /// </summary>
        /// <param name="box1"></param>
        /// <param name="box2"></param>
        /// <returns></returns>
        public static Box operator +(Box box1, Box box2)
        {
            Box newBox = new Box();
            newBox.Length = box1.Length + box2.Length;
            newBox.Width = box1.Width + box2.Width;
            newBox.Breadth = box1.Breadth + box2.Breadth;
            return newBox;
        }
        /// <summary>
        /// Override operator - in Box.
        /// </summary>
        /// <param name="box1"></param>
        /// <param name="box2"></param>
        /// <returns></returns>
        public static Box operator -(Box box1, Box box2)
        {
            Box newBox = new Box();
            newBox.Length = box1.Length - box2.Length;
            newBox.Width = box1.Width - box2.Width;
            newBox.Breadth = box1.Breadth - box2.Breadth;
            return newBox;
        }
        /// <summary>
        /// Override equal operator == in Box.
        /// </summary>
        /// <param name="box1"></param>
        /// <param name="box2"></param>
        /// <returns></returns>
        public static bool operator ==(Box box1, Box box2)
        {
            if ((box1.Length == box2.Length) &&
                (box1.Width == box2.Width) &&
                (box1.Breadth == box2.Breadth))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Override not equal operator != in Box.
        /// </summary>
        /// <param name="box1"></param>
        /// <param name="box2"></param>
        /// <returns></returns>
        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.Length == box2.Length) ||
                (box1.Width == box2.Width) ||
                (box1.Breadth == box2.Breadth))
            {
                return true;
            }
            return false;
        }
    }
}
