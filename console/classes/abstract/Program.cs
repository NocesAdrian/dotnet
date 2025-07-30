// See https://aka.ms/new-console-template for more information
using System;

namespace Main
{
    // abstract class can be only accessed through child class
    // abstract class cannot creates an object
    abstract class Animal
    {
        public abstract void Sound(); // abstract method does not have body "{}"

        public void Sleep() // normal method
        {
            Console.WriteLine("Zzz");
        }
    }
    // child class that access abstract class
    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat yela = new Cat();

            yela.Sound();
            yela.Sleep();
        }
    }
}
