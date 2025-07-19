// See https://aka.ms/new-console-template for more information


using Builder.Computer;

var builder = new ComputerBuilder();
var computer = builder
    .AddCPU(2600)
    .AddRAM(4)
    .AddStorage(2)
    .AddGPU("Nvidia")
    .Build();
computer.Print();

Console.WriteLine("Hello, World!");