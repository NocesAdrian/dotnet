// See https://aka.ms/new-console-template for more information


// output the character on specified index
string name = "Adrian Noces";
Console.WriteLine(name[3]); // outputs "i"

// output the index position of the character
Console.WriteLine(name.IndexOf("n")); // outputs 8 the index position of "n"

// get the index position of a character then outputs the rest after it
int charPos = name.IndexOf("N"); // get the index position of "N"
string lastName = name.Substring(charPos); // get the rest character after "N" -> "Noces"
Console.WriteLine(lastName);
