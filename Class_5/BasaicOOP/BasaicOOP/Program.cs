using System;

namespace BasaicOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var factory = new StudentFactory();
            var fahad = factory.GetStudent("Local Student");
            fahad.creditTransfer();
        }
    }
}
