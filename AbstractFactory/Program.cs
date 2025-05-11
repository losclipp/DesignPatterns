// See https://aka.ms/new-console-template for more information

using AbstractFactory.Reports.Bodyes;
using AbstractFactory.Reports.Factories;
using AbstractFactory.Reports.Formatters;
using AbstractFactory.Reports.Service;

Console.WriteLine("Hello, World!");

var reportFactory = FactoryGenerator.GenerateReportFactory(FormatType.HTML, BodyType.Table);
var service = new ReportService();
service.GenerateReport(reportFactory);

Console.ReadLine();