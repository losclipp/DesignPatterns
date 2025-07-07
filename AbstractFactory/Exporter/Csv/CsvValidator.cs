using AbstractFactory.Exporter.Abstract;

namespace AbstractFactory.Exporter.Csv;

public class CsvValidator: IValidator
{
    public bool Validate(string message)
    {
        Console.WriteLine("CSV Validation finished.");
        return true;
    }
}