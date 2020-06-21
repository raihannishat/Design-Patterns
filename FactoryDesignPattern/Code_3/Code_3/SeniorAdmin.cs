using System;
using System.Collections.Generic;
using System.Text;

namespace Code_3
{
    public class SeniorAdmin : Admin
    {
        public override void checkWorkingWay(Work work)
        {
            if (work.status.Equals("Good"))
            {
                Console.WriteLine(work.status);
            }
        }
    }
}
