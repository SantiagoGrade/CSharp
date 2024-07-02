using System.Diagnostics.CodeAnalysis;

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