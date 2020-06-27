using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public interface IEmailService
    {
        void SendEmail(string address, string subject, string body);
    }
}
