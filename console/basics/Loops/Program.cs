// See https://aka.ms/new-console-template for more information

// while loop
int i = 0;
while(i <= 5)
{
    Console.WriteLine(i);
    i++;
}

// do while loop
int x = 0;
do
{
    Console.WriteLine(x);
    x++;
}
while(x <= 5);

// for loop
for(int p = 0; p <= 10; p++)
{
    for(int q = 0; q <= p; q++)
    {
        Console.Write(q);
    }
    Console.WriteLine();
}
