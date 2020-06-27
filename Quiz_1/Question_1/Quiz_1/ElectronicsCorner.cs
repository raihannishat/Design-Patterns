using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz_1
{
    public class ElectronicsCorner : Corner
    {
        List<string> productList = new List<string>
        {
            "Mobile",
            "Laptop",
            "Smart Watch"
        };

        public override void BuyProduct(Product product)
        {
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine($"Name: {product.name}");
            Console.WriteLine($"Price: {product.price}");
        }

        public override void DisplayProduct()
        {
            productList.ForEach(x => Console.WriteLine(x));
        }
    }
}
