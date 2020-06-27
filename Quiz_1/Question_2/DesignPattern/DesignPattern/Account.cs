using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class Account
    {
        public void CreateAccount(string add, string sud, string body, IEmailService _email)
        {
            _email.SendEmail(add, sud, body);
        }

        public void RecoveryEmail(string add, string sud, string body, IEmailService _email)
        {
            _email.SendEmail(add, sud, body);
        }
    }
}
