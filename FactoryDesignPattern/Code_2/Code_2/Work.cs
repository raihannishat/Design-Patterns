using System;
using System.Collections.Generic;
using System.Text;

namespace Code_2
{
    public class Work
    {
        public string status { get; set; }

        public void SetStatus(string currentStatus)
        {
            status = currentStatus;
        }
    }
}
