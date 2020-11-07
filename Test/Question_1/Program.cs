using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var geometry = new Geometry();

            var circle = new Circle(3);
            var rectangle = new Rectangle(5, 7);
            var triangle = new Triangle(11, 13, 15);

            Console.WriteLine(geometry.CalculateArea(circle).ToString("0.00"));
            Console.WriteLine(geometry.CalculateArea(rectangle).ToString("0.00"));
            Console.WriteLine(geometry.CalculateArea(triangle).ToString("0.00"));

            Console.WriteLine();

            Console.WriteLine(geometry.CalculatePerimeter(circle).ToString("0.00"));
            Console.WriteLine(geometry.CalculatePerimeter(rectangle).ToString("0.00"));
            Console.WriteLine(geometry.CalculatePerimeter(triangle).ToString("0.00"));
        }
    }
}
