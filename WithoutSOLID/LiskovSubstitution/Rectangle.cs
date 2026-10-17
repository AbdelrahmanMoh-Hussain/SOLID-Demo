using System;
using System.Collections.Generic;
using System.Text;

namespace WithoutSOLID.LiskovSubstitution
{
    internal class Rectangle
    {
        public Rectangle(decimal width, decimal height)
        {
            Width = width;
            Height = height;
        }

        internal decimal Width { get; set; }
        internal decimal Height { get; set; }

        public decimal Area()
        {
            return Width * Height;
        }
    }
}
