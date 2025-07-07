using AbstractFactory.Exporter.Abstract;

namespace AbstractFactory.Exporter.Csv;

public class CsvExporter : IExporter
{
    public Task Export(string message)
    {
        Console.WriteLine("Export to CSV started.");
        Console.WriteLine("Export to CSV finished.");
        return Task.CompletedTask;
    }
}