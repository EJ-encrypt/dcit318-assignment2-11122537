using System;

namespace InterfacesApp
{
    // 1. Interface
    interface IMovable
    {
        void Move();
    }

    // 2. Implementers
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            IMovable bike = new Bicycle();

            car.Move();   // prints "Car is moving"
            bike.Move();  // prints "Bicycle is moving"
        }
    }
}
