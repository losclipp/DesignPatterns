// See https://aka.ms/new-console-template for more information



using Prototype.Car;

var car1 = new Car()
{
    Brand = "Opel",
    Model = "Astra",
    Year = 2010,
    Color = "Gray"
};

var car2 = car1.Clone()
    .WithOwner(new Person
    {
        Name = "John",
        Surname = "Smith",
        Age = 33,
    });


Console.WriteLine(car1.ToString());
Console.WriteLine(car2.ToString());

Console.WriteLine("Hello, World!");