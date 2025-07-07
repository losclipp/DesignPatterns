using AbstractFactory.Exporter.Abstract;

namespace AbstractFactory.Exporter.Json;

public class JsonExporter : IExporter
{
    public Task Export(string message)
    {
        Console.WriteLine("Export to JSON started.");
        Console.WriteLine("Export to JSON finished.");
        return Task.CompletedTask;
    }
}