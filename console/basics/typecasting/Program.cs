using System;

namespace TypeCasting
{
	class Program 
	{
		static void Main(string[] args)
		{
			// char to int
			char A = 'A';
			int A2 = (int) A;
			// or
			int resA = Convert.ToInt32(A);
			
			// int to char
			int B = 66;
			char B2 = (char) B;
			// or
			char resB = Convert.ToChar(B);
				
			// double to int to char
			double C = 67.7;
			int C2 = (int) C;
			char C3 = (char) C2;
			// or
			int resC = Convert.ToInt32(C);
			char resC2 = Convert.ToChar(C2);

			// bool to string
			bool D = true;
			string resD = Convert.ToString(D);

			// int to double
			int E = 10;
			double E2 = (double) E;
			// or
			double E3 = Convert.ToDouble(E);

			Console.WriteLine(A2);
			Console.WriteLine(B2);
			Console.WriteLine(C3);
			Console.WriteLine(E3 + 1.5);
		}
	}
}
