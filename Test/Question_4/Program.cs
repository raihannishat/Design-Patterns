using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 2D array size: ");
            var size = int.Parse(Console.ReadLine());
            var ara = new int[size, size];
            var sum = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    ara[i, j] = int.Parse(Console.ReadLine());

                    if (i + j == size - 1)
                    {
                        sum += ara[i, j];
                    }
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
