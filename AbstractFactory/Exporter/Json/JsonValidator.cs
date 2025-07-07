using AbstractFactory.Exporter.Abstract;

namespace AbstractFactory.Exporter.Json;

public class JsonValidator : IValidator
{
    public bool Validate(string message)
    {
        Console.WriteLine("JSON Validation finished.");
        return true;
    }
}