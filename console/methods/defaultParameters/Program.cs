// See https://aka.ms/new-console-template for more information
using System;

namespace Main
{
    class Program
    {
        static int country(string country = "Philippines") // good for handling empty parameter
        {
            Console.WriteLine(country);
            return 0;
        }

        static void Main(string[] args)
        {
            country("USA");
            country("Russia");
            country();
            country("Norway");
        }
    }
}
