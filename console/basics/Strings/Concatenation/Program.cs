// See https://aka.ms/new-console-template for more information

string firstname = "Adrian";
string lastname = "Noces";
string fullname = firstname + lastname;
Console.WriteLine(fullname);

// or
string firstName = "Adrian";
string lastName = "Noces";
string fullName = string.Concat(firstName, lastName);
Console.WriteLine(fullName);

// can be used by numbers too
int x = 10;
int y = 10;
int xy = x + y;
Console.WriteLine(xy);

string p = "10";
string q = "10";
string pq = p + q;
Console.WriteLine(pq);
