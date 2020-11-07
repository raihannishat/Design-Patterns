using System;
using System.Collections.Generic;
using System.Text;

namespace Question_1
{
    public class Triangle : Shape
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }

        public Triangle (int s1, int s2, int s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }
    }
}
