using System;
using System.Collections.Generic;
using System.Text;

namespace Question_1
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle (int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
