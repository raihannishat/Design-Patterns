using System;
using System.Collections.Generic;
using System.Text;

namespace BasaicOOP
{
    public class Admin
    {
        public bool workstatus { get; set; }
        public string performance { get; set; }

        public void givenWaiver(Student value)
        {
            if (value.cgpa > 3.8)
            {
                Console.WriteLine("Giving 10% Waiver");
            }
        }
    }
}
