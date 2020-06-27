using System;
using System.Collections.Generic;
using System.Text;

namespace Code_3
{
    public class SeniorEmployee : Employee
    {
        public override void processWorkingWay(Work work)
        {
            if (work.status.Equals("Good"))
            {
                Console.WriteLine();
            }
        }
    }
}
