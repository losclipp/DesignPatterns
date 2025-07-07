using AbstractFactory.Exporter.Abstract;

namespace AbstractFactory.Exporter.Csv;

public class CsvFactory: IExporterFactory
{
    public IValidator CreateValidator()
    {
        return new CsvValidator();
    }

    public IExporter CreateExporter()
    {
        return new CsvExporter();
    }
}