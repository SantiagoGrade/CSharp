/*
string[] faraudulentOrderIDs = new string[3];

faraudulentOrderIDs[0] = "A123";
faraudulentOrderIDs[1] = "B456";
faraudulentOrderIDs[2] = "C789";


string[] faraudulentOrderIDs = {"A123", "B456", "C789"};

Console.WriteLine($"First: {faraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {faraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {faraudulentOrderIDs[2]}");

faraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {faraudulentOrderIDs[0]}");

Console.WriteLine($"There are {faraudulentOrderIDs.Length} fraudulent orders to procces.");
*/

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