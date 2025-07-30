// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

string path = "folder";

if(!Directory.Exists(path))
{
    Directory.CreateDirectory(path);
    Console.WriteLine("Created!");
}
else
{
    Directory.Delete(path);
    Console.WriteLine("Already Exists, Deleted.");
}
