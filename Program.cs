using System;
using Generics.Models;


var result = GenericCalc<int>.Add(69, 69);
var doubleResult = GenericCalc<double>.Add(13.47, 56.22);

Console.WriteLine($"Result for AddFunc, ints: {result}\nResult for AddFunc, Double: {doubleResult}");

var divide = GenericCalc<int>.Div(138, 2);
var doubleDiv = GenericCalc<double>.Div(138.138, 2);

Console.WriteLine($"Result for DivFunc, ints: {divide}\nResult for DivFunc, double: {doubleDiv}");