namespace AbstractFactory.Exporter.Abstract;

public interface IExporter
{
    Task Export(string message);
}