// See https://aka.ms/new-console-template for more information
using System;

namespace Main
{
    class Program
    {
        // enum = enumaration
        enum Days
        {
            Mon, // 0
            Tue, // 1
            Wed, // 2
            Thu, // 3
            Fri, // 4
            Sat, // 5
            Sun, // 6
        }
        static void Main(string[] args)
        {
            Days day = Days.Thu; // return the string thu
            int dayNum = (int) Days.Thu; // return the number 3
            if (dayNum == 3)
            {
                Console.WriteLine($"Today is {day}");
            }

            // or case works
            switch(dayNum)
            {
                default:
                    Console.WriteLine("not a day");
                    break;
                case 0:
                    Console.WriteLine("Mon");
                    break;
                case 1:
                    Console.WriteLine("Tue");
                    break;
                case 2:
                    Console.WriteLine("Wed");
                    break;
                case 3:
                    Console.WriteLine("Thu");
                    break;
                case 4:
                    Console.WriteLine("Fri");
                    break;
                case 5:
                    Console.WriteLine("Sat");
                    break;
                case 6:
                    Console.WriteLine("Sun");
                    break;
            }
        }
    }
}
