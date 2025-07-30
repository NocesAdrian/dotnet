
// this is a single line comment

/* multi
 * line */

using System;

namespace HelloWorld {
	class Program 
	{
		static void Main(string[] args) 
		{
			int age = 18;
			long num = 10000000L;
			string name = "adrian";
			char grade = 'A';
			float fl = 1.5F;
			double dl = 1.5D;
			bool Bool1 = true, Bool2 = false;
			const double PI = 3.14;

            // can be any data type
            var number = 10;

			string result = $"My name is {name} i'am {age} years old i have an average grade '{grade}'";

			Console.WriteLine("Hello, World!");
			Console.Write("Hello, ");
			Console.Write("World\n");
			Console.WriteLine(result);

			Console.WriteLine($"num: {num} + PI: {PI} + age: {age} = {num + PI + age}");
		}
	}
}

