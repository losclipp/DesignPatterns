using AbstractFactory.Reports.Base;

namespace AbstractFactory.Reports.Formatters;

public class PdfFormatter : IReportFormatter
{
    public byte[] Format(IReportBody reportBody)
    {
        //Fake report generation
        Console.WriteLine("Formatting to PDF report.");
        return [];
    }
}