using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("=== Food Menu ===");
                Console.WriteLine("1) Vorta.");
                Console.WriteLine("2) Mas.");
                Console.WriteLine("3) Murgi.");
                Console.WriteLine("4) Exit");
                Console.Write("Enter your choice: ");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    VortaPackage vortaPackage = new VortaPackage();
                    Console.WriteLine($"You have eaten {vortaPackage.prepareFood()}");
                    Console.WriteLine($"You bill is {vortaPackage.foodPrice()} Taka");
                }
                else if (option == 2)
                {
                    IFood mas = new Mas(new VortaPackage());
                    Console.WriteLine($"You have eaten {mas.prepareFood()}");
                    Console.WriteLine($"You bill is {mas.foodPrice()} Taka");
                }
                else if (option == 3)
                {
                    IFood murgi = new Murgi(new VortaPackage());
                    Console.WriteLine($"You have eaten {murgi.prepareFood()}");
                    Console.WriteLine($"You bill is {murgi.foodPrice()} Taka");
                }
                else if (option == 4)
                {
                    Console.WriteLine("Mama abar aisen.");
                    break;
                }
            }
        }
    }
}
