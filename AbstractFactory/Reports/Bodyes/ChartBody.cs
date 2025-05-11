using AbstractFactory.Reports.Base;

namespace AbstractFactory.Reports.Bodyes;

public class ChartBody : IReportBody
{

    public void BuildReportBody(string reportBody)
    {
        Console.WriteLine("Building Chart data.");
        Content = "";
    }

    public string Content { get; private set; }
}