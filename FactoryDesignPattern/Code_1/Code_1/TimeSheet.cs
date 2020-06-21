using System;
using System.Collections.Generic;
using System.Text;

namespace Code_1
{
    public class TimeSheet
    {
        private string _task;

        public void SetTask(string task)
        {
            _task = task;
        }

        public void checkCurrentWork(Work work)
        {
            if (work.status.Equals("On going"))
            {
                _task = "Do it fast";
            }
        }
    }
}
