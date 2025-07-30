// See https://aka.ms/new-console-template for more information
using System;

namespace Main
{
    // acts like template no body variable or medthod
    interface AnimalSound
    {
        void Sound();
    }

    interface AnimalName
    {
        void name();
    }

    class Cat : AnimalName, AnimalSound // a child class can only inherit multiple parent class if its inteface parent
    {
        public void name()
        {
            Console.WriteLine("Yela");
        }

        public void Sound()
        {
            Console.WriteLine("Meow!");
        }
    }
    class Proram
    {
        static void Main()
        {
            Cat yela = new Cat();
            yela.name();
            yela.Sound();
        }
    }
}
