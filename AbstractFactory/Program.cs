// See https://aka.ms/new-console-template for more information

using AbstractFactory.Reports.Bodyes;
using AbstractFactory.Reports.Factories;
using AbstractFactory.Reports.Formatters;

Console.WriteLine("Hello, World!");

var reportFactory = FactoryGenerator.GenerateReportFactory(FormatType.PDF, BodyType.Chart);
reportFactory.GenerateReport();

Console.ReadLine();