using AbstractFactory.Reports.Base;

namespace AbstractFactory.Reports.Bodyes;

public class TableBody : IReportBody
{
    public void BuildReportBody(string reportBody)
    {
        Console.WriteLine("Building Table Body.");
        Content = "";
    }

    public string Content { get; private set; }
}