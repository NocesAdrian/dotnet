// See https://aka.ms/new-console-template for more information

// class are templates to create an objects
// for example a class fruit you can create a variety of fruit(objects) on it like apple mango banana


using System;

namespace Main
{
    // new class
    class Fruit
    {
        // object info template
        public string name;
        public string color;
        
        // constructor
        public Fruit(string name = "none", string color = "none")
        {
            this.name = name;
            this.color = color;
        }
    }

    // main class
    class Program
    {
        static void Main(string[] args)
        {
            // creates object apple but configure info manual
            Fruit apple = new Fruit();
            apple.name = "Apple";
            apple.color = "Red";
            
            // creates object banana but using the construct
            Fruit banana = new Fruit("Banana", "Yellow");

            Console.WriteLine($"Fruit name: {apple.name}\t color: {apple.color}");
            Console.WriteLine($"Fruit name: {banana.name}\t color: {banana.color}");
        
        }
    }
}
