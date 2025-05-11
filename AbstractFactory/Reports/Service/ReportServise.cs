using AbstractFactory.Reports.Base;

namespace AbstractFactory.Reports.Service;

public class ReportService
{
    public byte[] GenerateReport(IReportFactory factory)
    {
        var body = factory.CreateReportBody();
        var formatter = factory.CreateReportFormatter();
        
        body.BuildReportBody("");
        return formatter.Format(body);
    }
}