// See https://aka.ms/new-console-template for more information
using System;

namespace Main
{
    class Program
    {
        static int add(int x = 0, int y = 0)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int result = add(5, 10);
            Console.WriteLine(result);
        }
    }
}
