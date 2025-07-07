using AbstractFactory.Exporter.Abstract;

namespace AbstractFactory.Exporter.Xml;

public class XmlExporter : IExporter
{
    public Task Export(string message)
    {
        Console.WriteLine("Export to XML started.");
        Console.WriteLine("Export to XML finished.");
        return Task.CompletedTask;
    }
}