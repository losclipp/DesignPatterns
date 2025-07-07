// See https://aka.ms/new-console-template for more information

using AbstractFactory.Logger.Abstraction.Enums;
using AbstractFactory.Logger.Factories;

var logger = LoggerFactory.CreateLogger(Output.File, Format.Json);
await logger.LogAsync("User logged in");
logger.Dispose();

Console.ReadLine();