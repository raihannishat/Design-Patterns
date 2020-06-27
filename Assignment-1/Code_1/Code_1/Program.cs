using System;
using System.Collections.Generic;

namespace Code_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> menu = new List<string>
            {
                "1) In Progress TimeSheet",
                "2) Completed TimeSheet"
            };

            var capacity = new Capacity();
            menu.ForEach(x => Console.WriteLine(x));
            Console.Write("Chose an option: ");

            var option = int.Parse(Console.ReadLine());
            var timeSheetFactory = new TimeSheetFactory();
            var timeSheet = timeSheetFactory.GetTimeSheet(option);

            timeSheet.setProcess("Write Code");
            capacity.setStatus("On going");
            timeSheet.checkProgressStatus(capacity);
        }
    }
}
