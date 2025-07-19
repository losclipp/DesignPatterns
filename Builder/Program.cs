// See https://aka.ms/new-console-template for more information


using Builder.User;

var builder = new UserBuilder();

var user = builder
    .AddName("John")
    .AddSurname("Smith")
    .AddAge(33)
    .AddEmail("someemail@gmail.com")
    .AddPhone("+73192031")
    .Build();

Console.WriteLine(user);

Console.WriteLine("Hello, World!");