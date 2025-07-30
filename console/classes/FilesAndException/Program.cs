// See https://aka.ms/new-console-template for more information

using System.IO;

string writeText = "Hello im adrian\n";
File.WriteAllText("filename.txt", writeText);

try
{
    string writeText2 = "im adrian, 18 years old wanting a thinkpad\n";
    File.WriteAllText("filename.txt", writeText2);
    File.AppendAllText("filename.txt", writeText2);
}
catch(Exception e)
{
    Console.WriteLine("error: " + e.Message);
}
finally
{
    Console.WriteLine("Finished");
}

if(File.Exists("filename.txt")) 
{
    // (src,dest)
    try{
        File.Delete("filename1.txt");
        File.Delete("filename2.txt");
        File.Delete("text.txt");
        File.Create("filename2.txt");
        File.Copy("filename.txt", "filename1.txt");
        // moves content to other file or used to rename file
        File.Move("filename2.txt", "text.txt");
    }
    catch(Exception e)
    {
        Console.WriteLine("error: " + e.Message);
    }
}
else
{
    Console.WriteLine("Finished");
}

string readText = File.ReadAllText("filename1.txt");
Console.WriteLine(readText);

// bunos
/*
    Directory.Delete("Folder", true); // true mean wipe all files inside it
*/

