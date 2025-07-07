// See https://aka.ms/new-console-template for more information

using AbstractFactory.Exporter;
using AbstractFactory.Exporter.Abstract.Enum;

var factoryLoader = new FactoryLoader();
var Factory = factoryLoader.GetExporterFactory(Format.XML);

var data = "message";
var validator = Factory.CreateValidator();
var exporter = Factory.CreateExporter();

validator.Validate(data);
await exporter.Export(data);

Console.ReadLine();