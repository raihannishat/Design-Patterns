using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternProblem
{
    public class Manager : Employee
    {
        public Manager(double basicSalary) : base(basicSalary) { }

        public override double calculateHomeAllowance()
        {
            return basicSalary * 0.10;
        }

        public override double calculateMedicalAllowance()
        {
            return basicSalary * 0.10;
        }
    }
}
