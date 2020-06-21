using System;

namespace Code_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var work = new Work();
            work.SetStatus("Running");
            var factory = new AdminFactory();
            var option = int.Parse(Console.ReadLine());
            var admin = factory.GetAdmin(option);
            admin.checkWorkProcess(work);
        }
    }
}
