using AbstractFactory.Reports.Base;

namespace AbstractFactory.Reports.Formatters;

public class HtmlFormatter : IReportFormatter
{
    public byte[] Format(IReportBody reportBody)
    {
        //Fake report generation
        Console.WriteLine("Formatting to HTML report.");
        return [];
    }
}