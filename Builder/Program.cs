// See https://aka.ms/new-console-template for more information


using Builder.Person;

var builder = new PersonBuilder();
var person = builder
    .AddName("John")
    .AddSurname("Doe")
    .AddAge(75)
    .AddPassportNumber("adsfasd545651")
    .Build();

Console.WriteLine(person.ToString());

Console.WriteLine("Hello, World!");