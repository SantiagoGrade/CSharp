using System.Diagnostics.CodeAnalysis;
using System.Globalization;

string[] codeFraud = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string element in codeFraud)
{
    if(element.StartsWith("B"))
    {
        Console.WriteLine(element);
    }
};