using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Engine
    {
        public Engine() { }

        public void AddEngine(int cylinders)
        {
            Console.WriteLine($"{cylinders} Cylinder Engine Added");
        }
    }
}
