using System;
using System.Collections.Generic;
using System.Text;

namespace Question_1
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
