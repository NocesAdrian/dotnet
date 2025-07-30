// See https://aka.ms/new-console-template for more information
using System;

namespace Application
{
    // parent class
    class Laptop
    {
        public string brand = "lenovo";
    }

    // derived class child
    class Series : Laptop
    {
        public string model;

        public Series(string model = "none")
        {
            this.model = model;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Series thinkpad1 = new Series(model: "t490");
            Series thinkpad2 = new Series(model: "x13");

            Console.WriteLine($"Brand: {thinkpad1.brand}\tModel: {thinkpad1.model}");
            Console.WriteLine($"Brand: {thinkpad2.brand}\tModel: {thinkpad2.model}");
        }
    }
}
