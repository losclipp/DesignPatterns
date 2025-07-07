using AbstractFactory.Exporter.Abstract;
using AbstractFactory.Exporter.Abstract.Enum;
using AbstractFactory.Exporter.Csv;
using AbstractFactory.Exporter.Json;
using AbstractFactory.Exporter.Xml;

namespace AbstractFactory.Exporter;

public class FactoryLoader
{
    private readonly Dictionary<Format, IExporterFactory> _factories = new()
    {
        { Format.CSV, new CsvFactory() },
        { Format.JSON, new JsonFactory() },
        { Format.XML, new XmlFactory() }
    };

    public IExporterFactory GetExporterFactory(Format format)
    {
        return _factories[format];
    }
}