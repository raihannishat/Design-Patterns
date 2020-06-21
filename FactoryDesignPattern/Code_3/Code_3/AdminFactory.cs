using System;
using System.Collections.Generic;
using System.Text;

namespace Code_3
{
    public class AdminFactory
    {
        public Admin GetAdmin(int option)
        {
            Admin admin = null;

            admin = option switch
            {
                1 => new JuniorAdmin(),
                2 => new SeniorAdmin(),
                _ => null
            };

            return admin;
        }
    }
}
