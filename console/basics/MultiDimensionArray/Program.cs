// See https://aka.ms/new-console-template for more information
// 2d array has column and row add [,] for 2d array, add another [,,] for 3d array and more..
int[,] arr = { {3,4}, {1,3} };
int[,,] arrr = { {{12},{10}}, {{10},{10}} };

arr[0, 1] = 6;
Console.WriteLine(arr[0,1]); // outputs 6

for(int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]}, ");
    }
    Console.WriteLine();
}
