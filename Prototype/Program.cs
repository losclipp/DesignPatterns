// See https://aka.ms/new-console-template for more information


using Prototype.Car;

var car = new Car
{
    Brand = "Open",
    Model = "Astra",
    Year = 2000,
    Owner = new Person()
    {
        Name = "John",
        Surname= "Smith",
        Age = 35
    }

};



var car2 = car.Clone();

car.Owner.Surname = "Wick";

Console.WriteLine(car.ToString());
Console.WriteLine(car2.ToString());
Console.WriteLine("Hello, World!");