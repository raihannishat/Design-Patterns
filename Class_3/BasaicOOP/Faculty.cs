using System;
using System.Collections.Generic;
using System.Text;

namespace BasaicOOP
{
    public class Faculty
    {
        public string id { get; set; }
        public string department { get; set; }
        public double salary { get; set; }

        public void regesterStudents()
        {
            Console.WriteLine("Regester of all students");
        }
    }
}
