using System;
using System.ComponentModel;
using System.Net;
using Generics.Models;


var result = GenericCalc<int>.Add(35, 34);
var doubleResult = GenericCalc<double>.Add(13.47, 56.22);

Console.WriteLine($"Result for AddFunc, ints: {result}\nResult for AddFunc, Double: {doubleResult}");

var divide = GenericCalc<int>.Div(138, 2);
var doubleDiv = GenericCalc<double>.Div(138.138, 2);

Console.WriteLine($"Result for DivFunc, ints: {divide}\nResult for DivFunc, double: {doubleDiv}");



Container<string> containerString = new();
var antall = containerString.GetAll().Length;
Console.WriteLine($"\nthere is currently {antall} number of objects in the list");


Console.WriteLine("Add something to the list:");
string? sopp = Console.ReadLine();
if (sopp.IsWhiteSpace() || sopp == null)
{
    Console.WriteLine("Nothing added");
}


containerString.Add("Shitbox Test1");
containerString.Add(sopp!);


Console.WriteLine("Displaying all the things in the list:");
var listaa = containerString.GetAll();
foreach (string things in listaa)
{
    Console.WriteLine(things);
}

Console.WriteLine("\nTesting GetByIndex func");
Console.WriteLine(containerString.GetByIndex(0));