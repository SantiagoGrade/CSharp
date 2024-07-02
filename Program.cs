using System.Diagnostics.CodeAnalysis;
using System.Globalization;

string[] names = {"Rowena", "Robin", "Bao"};
foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250};
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine($"We have {sum} items in inventory.");

int[] numbers = {3, 7, 2, 9, 2, 7, 3, 6, 2, 1};
int hightes = 0;
foreach (int number in numbers)
{
    if (number > hightes)
    {

    }
}
