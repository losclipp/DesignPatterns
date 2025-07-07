namespace AbstractFactory.Exporter.Abstract;

public interface IExporterFactory
{
   IValidator CreateValidator();
   IExporter CreateExporter();
}