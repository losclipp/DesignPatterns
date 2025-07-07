using AbstractFactory.Exporter.Abstract;

namespace AbstractFactory.Exporter.Xml;

public class XmlValidator : IValidator
{
    public bool Validate(string message)
    {
        Console.WriteLine("XML Validation finished.");
        return true;
    }
}