using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class FoodDecorator : IFood
    {
        public IFood plainFood;

        public FoodDecorator(IFood plainFood)
        {
            this.plainFood = plainFood;
        }

        public virtual double foodPrice()
        {
            return plainFood.foodPrice();
        }

        public virtual string prepareFood()
        {
            return plainFood.prepareFood();
        }
    }
}
