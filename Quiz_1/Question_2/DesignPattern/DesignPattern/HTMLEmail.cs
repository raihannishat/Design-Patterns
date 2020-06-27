using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class HTMLEmail : IEmailService
    {
        public void SendEmail(string address, string subject, string body)
        {
            Console.WriteLine($"<p>{address}</p>");
            Console.WriteLine($"<p>{subject}</p>");
            Console.WriteLine($"<p>{body}</p>");
        }
    }
}
