using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Question_1
{
    public class Geometry
    {
        public double CalculateArea(Shape shape)
        {
            if (shape is Circle)
            {
                var calculate = shape as Circle;
                return Math.PI * (calculate.Radius * calculate.Radius);
            }
            else if (shape is Rectangle)
            {
                var calculate = shape as Rectangle;
                return calculate.Height * calculate.Width;
            }
            else if (shape is Triangle)
            {
                var calculate = shape as Triangle;
                var s = 0.5 * (calculate.side1 + calculate.side2 + calculate.side3);
                var area = s * (s - calculate.side1) * (s - calculate.side2) * (s - calculate.side3);
                return Math.Sqrt(area);
            }

            return 0.0;
        }

        public double CalculatePerimeter(Shape shape)
        {
            if (shape is Circle)
            {
                var calculate = shape as Circle;
                return 2 * Math.PI * calculate.Radius;
            }
            else if (shape is Rectangle)
            {
                var calculate = shape as Rectangle;
                return 2 * (calculate.Height + calculate.Width);
            }
            else if (shape is Triangle)
            {
                var calculate = shape as Triangle;
                return calculate.side1 + calculate.side2 + calculate.side3;
            }

            return 0.0;
        }
    }
}
