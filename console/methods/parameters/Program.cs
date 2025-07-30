// See https://aka.ms/new-console-template for more information
using System;

namespace Main
{
    class Proram
    {
        static int MyMethod(string name, int age)
        {
            Console.WriteLine($"name: {name}\t age: {age}");
            return 0;
        }

        static void Main(string[] args)
        {
            MyMethod("Noces Adrian", 18);
            MyMethod("Zian Ringor", 17);
            MyMethod("Miguel Delizo", 18);
        }
    }
}
