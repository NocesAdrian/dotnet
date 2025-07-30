// See https://aka.ms/new-console-template for more information

for(int i = 0; i <= 10; i++)
{
    if(i == 3)
    {
        continue;
    } 
    else if(i == 9)
    {
        break;
    }

    Console.WriteLine(i);
}
