using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Check obj1 = new Check();
            Check obj2 = new Check();
            Check obj3 = new Check();

            Console.WriteLine();

            NewCheck o1 = new NewCheck();
            NewCheck o2 = new NewCheck();
            NewCheck o3 = new NewCheck();
        }
    }
}
