using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Mas : FoodDecorator
    {
        public Mas(IFood plainFood) : base(plainFood) { }

        public override string prepareFood()
        {
            return base.prepareFood() + ", Mas";
        }

        public override double foodPrice()
        {
            return base.foodPrice() + 50;
        }
    }
}
