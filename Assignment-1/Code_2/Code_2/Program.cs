using System;
using System.Collections.Generic;

namespace Code_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> menu = new List<string>
            {
                "1) Moderator",
                "2) OfficeAssistant"
            };
            
            var progress = new Progress();
            menu.ForEach(x => Console.WriteLine(x));
            Console.Write("Chose an option: ");

            var option = int.Parse(Console.ReadLine());
            var adminFactory = new AdminFactory();
            var admin = adminFactory.GetAdmin(option);

            admin.checkProcess(progress);
            progress.setStatus("On going");
        }
    }
}
