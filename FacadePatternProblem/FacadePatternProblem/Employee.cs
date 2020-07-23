using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternProblem
{
    public abstract class Employee
    {
        public double basicSalary { get; set; }

        public Employee(double basicSalary)
        {
            this.basicSalary = basicSalary;
        }

        public abstract double calculateHomeAllowance();
        public abstract double calculateMedicalAllowance();
    }
}
