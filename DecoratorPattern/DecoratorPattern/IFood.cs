using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public interface IFood
    {
        string prepareFood();
        double foodPrice();
    }
}
