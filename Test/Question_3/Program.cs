using System;
using System.Linq;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char[] ara = number.ToString().ToCharArray();
            Array.Reverse(ara);
            Console.WriteLine(ara);

            foreach (var item in ara)
            {
                if (item % 2 == 0)
                {
                    Console.Write($"{item},");
                }
            }

            Console.WriteLine();

            foreach (var item in ara)
            {
                if (item % 2 == 1)
                {
                    Console.Write($"{item},");
                }
            }
        }
    }
}
