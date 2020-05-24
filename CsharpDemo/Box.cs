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
        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }
        public Box() : this(1, 1, 1) { }
        public Box(double l, double w, double b)
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
            if ((box1.Length != box2.Length) ||
                (box1.Width != box2.Width) ||
                (box1.Breadth != box2.Breadth))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Override ToString() in Box.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"Length of Box : {Length}, width : {Width}, breadth : {Breadth}");
        }
        /// <summary>
        /// Override explicit operator int in Box.
        /// </summary>
        /// <param name="box"></param>
        public static explicit operator int(Box box)
        {
            return (int)(box.Length + box.Width + box.Breadth) / 3;
        }
        /// <summary>
        /// Override implicit operator Box, we can create a new Box by cast int to Box.
        /// </summary>
        /// <param name="i"></param>
        public static implicit operator Box(int i)
        {
            return new Box(i, i, i);
        }
    }
}
