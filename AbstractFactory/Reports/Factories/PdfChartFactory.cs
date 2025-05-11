using AbstractFactory.Reports.Base;
using AbstractFactory.Reports.Bodyes;
using AbstractFactory.Reports.Formatters;

namespace AbstractFactory.Reports.Factories;

public class PdfChartFactory : IReportFactory
{
    private readonly ChartBody _tableBody = new();
    private readonly PdfFormatter _formatter = new();
    
    public byte[] GenerateReport()
    {
        _tableBody.BuildReportBody("Chart");
        return _formatter.Format(_tableBody);
    }
}