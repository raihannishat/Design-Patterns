using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            //account.CreateAccount("raihan", "12345", "sdfsdf", new FormatedEmail());
            account.RecoveryEmail("asif", "zihad", "antu", new HTMLEmail());
        }
    }
}
