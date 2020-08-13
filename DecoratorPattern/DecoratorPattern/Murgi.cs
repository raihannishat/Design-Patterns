using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Murgi : FoodDecorator
    {
        public Murgi(IFood plainFood) : base(plainFood) { }

        public override double foodPrice()
        {
            return base.foodPrice() + 100;
        }

        public override string prepareFood()
        {
            return base.prepareFood() + ", Murgi";
        }
    }
}
