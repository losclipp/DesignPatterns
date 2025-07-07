using AbstractFactory.Exporter.Abstract;

namespace AbstractFactory.Exporter.Xml;

public class XmlFactory : IExporterFactory
{
    public IValidator CreateValidator()
    {
        return new XmlValidator();
    }

    public IExporter CreateExporter()
    {
        return new XmlExporter();
    }
}