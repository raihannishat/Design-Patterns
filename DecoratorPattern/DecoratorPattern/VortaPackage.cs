using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class VortaPackage : IFood
    {
        public double foodPrice()
        {
            return 60;
        }

        public string prepareFood()
        {
            return "Vat, Vorta";
        }
    }
}
