using System;
using System.Collections.Generic;
using System.Text;

namespace Code_3
{
    public class JuniorEmployee : Employee
    {
        public override void processWorkingWay(Work work)
        {
            if (work.status.Equals("Not Good"))
            {
                Console.WriteLine();
            }
        }
    }
}
