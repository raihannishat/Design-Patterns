using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class FormatedEmail : IEmailService
    {
        public void SendEmail(string address, string subject, string body)
        {
            Console.WriteLine($"{address} {subject} {body}");
        }
    }
}
