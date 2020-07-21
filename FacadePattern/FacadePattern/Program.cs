using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Start making Car..............");
            Body body = new Body();
            body.AddBody(BodyType.Suv);
            Engine engine = new Engine();
            engine.AddEngine(4);
            Seats seats = new Seats();
            seats.AddSeats(4);
            Wheels wheels = new Wheels();
            wheels.AddWheels(4);
            Console.WriteLine("Ended Making Car..............");
            */

            ICar car = new CarFacade();
            car.BuildCar();
        }
    }
}
