// See https://aka.ms/new-console-template for more information
using System;

Console.Write("Enter Your UserName: ");
string username = Console.ReadLine();
Console.Write("Enter Your Age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"username: {username}\nage:  {age}");
