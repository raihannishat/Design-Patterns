using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string address, string subject, string body)
        {
            Console.WriteLine("{0}", address);
            Console.WriteLine("{0}", subject);
            Console.WriteLine("{0}", body);
        }
    }
}
