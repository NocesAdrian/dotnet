// See https://aka.ms/new-console-template for more information
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
int[] prices = {2000, 3000, 2500, 2000};

for(int i = 0; i < cars.Length; i++)
{
    Console.WriteLine($"car: {cars[i]}, price: ${prices[i]}");
}

// sort array A -> Z
Array.Sort(cars); // int can be sorted too 1 -> infinite
foreach(string i in cars)
{
    Console.WriteLine(i);
}

// creates empty array that can contains 4 elements
int[] arr = new int[4];
arr[0] = 10;
Console.WriteLine(arr[0]);



/*
foreach(string arrCars in cars)
{
    foreach(int arrPrice in prices)
    {
        Console.WriteLine($"car: {arrCars}, price: {arrPrice}");
    }
}
*/
