using System;
using System.Collections.Generic;
using System.Text;

namespace Code_1
{
    public class TimeSheet
    {
        private string process;

        public void setProcess(string process)
        {
            this.process = process;
        }

        public void checkProgressStatus(Capacity capacity)
        {
            if (capacity.status.Equals("One thousand"))
            {
                process = "assigned it to stuff";
            }
        }
    }
}
