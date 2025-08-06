using System;

namespace InheritanceApp
{
    // 1. Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // 2. Derived classes
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal generic = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            generic.MakeSound();  // prints "Some generic sound"
            dog.MakeSound();      // prints "Bark"
            cat.MakeSound();      // prints "Meow"
        }
    }
}
