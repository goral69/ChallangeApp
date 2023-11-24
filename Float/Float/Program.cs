// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

CultureInfo culture = new CultureInfo("en-US");
float parsedValue;

if (float.TryParse("0.5f", NumberStyles.Float, culture, out parsedValue))
{
    Console.WriteLine("Parsowanie udane. Wartość: " + parsedValue);
}
else
{
    Console.WriteLine("Nieudane parsowanie.");
}

//try
//{
//    float parsedValue = float.Parse("0.5f");
//    Console.WriteLine("Parsowanie udane. Wartość: " + parsedValue);
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Błąd parsowania: " + ex.Message);
//}