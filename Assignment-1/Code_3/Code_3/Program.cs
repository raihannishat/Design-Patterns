using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Code_3
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

            var work = new Work();
            menu.ForEach(x => Console.WriteLine(x));
            Console.Write("Chose an option: ");

            var option = int.Parse(Console.ReadLine());
            var employeeFactory = new EmployeeFactory();
            var employee = employeeFactory.GetEmployee(option);

            work.setStatus("Good");
            employee.processWorkingWay(work);
        }
    }
}
