using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz_1
{
    public abstract class Corner
    {
        public string shopnumber { get; set; }
        public string discountStatus { get; set; }

        public abstract void DisplayProduct();
        public abstract void BuyProduct(Product product);
    }
}
