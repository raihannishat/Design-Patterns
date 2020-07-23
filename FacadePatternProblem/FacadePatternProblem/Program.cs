using System;

namespace FacadePatternProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Manager(30000);

            Console.WriteLine($"{manager.basicSalary} :- " +
                              $"{manager.calculateHomeAllowance()}, " +
                              $"{manager.calculateMedicalAllowance()}");

            Employee staff = new Staff(20000);
            Console.WriteLine($"{staff.basicSalary} :- " +
                              $"{staff.calculateHomeAllowance()}, " +
                              $"{staff.calculateMedicalAllowance()}");
        }
    }
}
