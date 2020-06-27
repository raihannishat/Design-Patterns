using System;
using System.Collections.Generic;

namespace Quiz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> menu = new List<string>
            {
                "1) Press 1 to Ornaments Corner",
                "2) Press 2 to Clothing Corner",
                "3) Press 3 to Electronics Corner"
            };

            menu.ForEach(x => Console.WriteLine(x));
            Console.Write("Chose an option: ");

            var option = int.Parse(Console.ReadLine());
            var cornerFactory = new CornerFactory();
            var corner = cornerFactory.GetCorner(option);

            //var product = new Product() { name = "xyz", price = 5000 };

            //corner.BuyProduct(product);
            corner.DisplayProduct();
        }
    }
}
