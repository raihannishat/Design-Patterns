using System;
using System.Collections.Generic;
using System.Text;

namespace Code_3
{
    public class JuniorAdmin : Admin
    {
        public override void checkWorkingWay(Work work)
        {
            if (work.status.Equals("Not Good"))
            {
                Console.WriteLine(work.status);
            }
        }
    }
}
