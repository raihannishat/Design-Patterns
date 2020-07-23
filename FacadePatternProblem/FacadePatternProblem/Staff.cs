using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternProblem
{
    public class Staff : Employee
    {
        public Staff(double basicSalary) : base(basicSalary) { }

        public override double calculateHomeAllowance()
        {
            return basicSalary * 0.05;
        }

        public override double calculateMedicalAllowance()
        {
            return basicSalary * 0.05;
        }
    }
}
