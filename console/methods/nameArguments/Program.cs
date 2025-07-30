// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace Main
{
    class Program
    {
        static int youngest(string child1, string child2, string child3) 
        {
            Console.WriteLine($"the youngest child is {child3}");
            return 0;
        }

        static void Main(string[] args)
        {
            youngest(child1: "John", child3: "Zian", child2: "Adrian");
        }
    }
}
