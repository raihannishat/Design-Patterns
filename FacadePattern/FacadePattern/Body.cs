using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Body
    {
        public Body() { }

        public void AddBody(BodyType bodyType)
        {
            Console.WriteLine($"{Enum.GetName(typeof(BodyType), bodyType)} Body Added");
        }
    }
}
