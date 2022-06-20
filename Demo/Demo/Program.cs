// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using Demo;

Console.WriteLine("Hello, World!");


var foo = new Calculator();


foo.Value = foo.DoSum(2.5, 2);
foo.Display(foo.Value.ToString());


var carOne = new Car();
carOne.NumberOfSeats = 5;
carOne.Make = "Volkswagen";
carOne.Model = "Caddy";

Console.WriteLine(carOne);

var carTwo = new Car();
carTwo.NumberOfSeats = 7;
carTwo.Make = "Volkswagen";
carTwo.Model = "Caddy Maxi";

Console.WriteLine(carTwo);

Console.ReadLine();