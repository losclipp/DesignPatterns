// See https://aka.ms/new-console-template for more information


using System.Drawing;
using Prototype.PrototypeRegistry;

var carRegistry = new PrototypeCarRegistry();
carRegistry.AddItem(new Car()
{
    Model = "Opel",
    Year = 2000,
    Color = "Blue",
});
carRegistry.AddItem(new Car()
{
    Model = "Bmw",
    Year = 2010,
    Color = "Black",
});

carRegistry.GetCarByModel("Opel");

var car1 = carRegistry.GetCarByModel("Opel");
var car2 = carRegistry.GetCarByModel("Opel");
car1.Color = "Red";


Console.WriteLine(car1.ToString());
Console.WriteLine(car2.ToString());

Console.WriteLine("Hello, World!");