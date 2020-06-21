using System;
using System.Collections.Generic;
using System.Text;

namespace Code_2
{
    public class Admin : ITaks
    {
        public int serial { get; set; }

        public void checkWorkProcess(Work work)
        {
            if (serial == 342)
            {
                work.SetStatus("In progress");
            }
        }
    }
}
