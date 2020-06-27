using System;
using System.Collections.Generic;
using System.Text;

namespace Code_3
{
    public class EmployeeFactory
    {
        public Employee GetEmployee(int option)
        {
            Employee employee = null;

            employee = option switch
            {
                1 => new JuniorEmployee(),
                2 => new SeniorEmployee(),
                _ => null
            };

            return employee;
        }
    }
}
