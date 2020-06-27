using System;
using System.Collections.Generic;
using System.Text;

namespace Code_1
{
    public class TimeSheetFactory
    {
        public TimeSheet GetTimeSheet(int option)
        {
            TimeSheet timeSheet = null;

            timeSheet = option switch
            {
                1 => new InProgressTimeSheet(),
                2 => new CompletedTimeSheet(),
                _ => null
            };

            return timeSheet;
        }
    }
}
