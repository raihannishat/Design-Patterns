using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class NewCheck
    {
        public static int count { get; set; }

        public NewCheck()
        {
            count++;
            Console.WriteLine(count);
        }
    }
}
