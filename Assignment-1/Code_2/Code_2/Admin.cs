using System;
using System.Collections.Generic;
using System.Text;

namespace Code_2
{
    public class Admin : IActivity
    {
        public int id { get; set; }

        public void checkProcess(Progress progress)
        {
            if (id == 3763)
            {
                progress.setStatus("On going");
            }
        }
    }
}
