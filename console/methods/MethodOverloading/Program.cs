// See https://aka.ms/new-console-template for more information



// MULTIPLE methods can have the same name as long as it has different data return

using System;

namespace Main
{
    class Program
    {
        static int add(int x = 0, int y = 0)
        {
            return x + y;
        }

        static double add(double x = 0, double y = 0)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int num1 = add(1, 2);
            double num2 = add(1.1,2.2);
            Console.WriteLine($"int: \t{num1}\ndouble \t{num2}");
        }
    }
}
