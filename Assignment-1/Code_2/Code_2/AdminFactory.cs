using System;
using System.Collections.Generic;
using System.Text;

namespace Code_2
{
    public class AdminFactory
    {
        public Admin GetAdmin(int option)
        {
            Admin admin = null;

            admin = option switch
            {
                1 => new Moderator(),
                2 => new OfficeAssistant(),
                _ => null
            };

            return admin;
        }
    }
}
