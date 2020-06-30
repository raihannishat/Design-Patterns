using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Check
    {
        public int count { get; set; }

        public Check()
        {
            count++;
            Console.WriteLine(count);
        }
    }
}
