// See https://aka.ms/new-console-template for more information
using System;

namespace Main
{
    // parent class
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("the animal made a sound!");
        }
    }

    // child class 1
    class Cat : Animal
    {
        public string name;
        public override void Sound()
        {
            Console.WriteLine($"{this.name}: meow!");
        }

        public Cat(string name = "none")
        {
            this.name = name;
        }
    }
    // child class 2
    class Dog : Animal
    {
        public string name;
        public override void Sound()
        {
            Console.WriteLine($"{this.name}: Woof!");
        }

        public Dog(string name = "none")
        {
            this.name = name;
        }
    }
    // child class 3
    class Pig : Animal
    {
        public string name;
        public override void Sound()
        {
            Console.WriteLine($"{this.name}: oink!");
        }

        public Pig(string name = "none")
        {
            this.name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat Cat1 = new Cat("Yela");
            Dog Dog1 = new Dog("john");
            Pig Pig1 = new Pig("shayne");

            Cat1.Sound();
            Dog1.Sound();
            Pig1.Sound();
        }
    }
}
