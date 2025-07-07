using AbstractFactory.Exporter.Abstract;

namespace AbstractFactory.Exporter.Json;

public class JsonFactory : IExporterFactory
{
    public IValidator CreateValidator()
    {
        return new JsonValidator();
    }

    public IExporter CreateExporter()
    {
        return new JsonExporter();
    }
}