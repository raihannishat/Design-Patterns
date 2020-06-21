using System;
using System.Collections.Generic;

namespace Code_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> menu = new List<string>
            {
                "1) Junior Admin",
                "2) Senior Admin"
            };

            menu.ForEach(x => Console.WriteLine(x));

            var work = new Work();
            var adminFactory = new AdminFactory();
            var option = int.Parse(Console.ReadLine());
            var admin = adminFactory.GetAdmin(option);
            
            work.status = "Good";
            admin.checkWorkingWay(work);
        }
    }
}
