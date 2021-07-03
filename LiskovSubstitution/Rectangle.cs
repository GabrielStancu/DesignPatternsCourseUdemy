using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public Rectangle()
        {

        }
    }
}
