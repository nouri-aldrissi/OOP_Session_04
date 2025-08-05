using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP04.allClass
{
    internal class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(int size)
        {
            Width = size;
            Height = size;
        }

        public override string ToString()
        {
            return $"Width: {Width}, Height: {Height}";
        }

    }
}
