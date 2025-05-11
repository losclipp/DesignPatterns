

using AbstractFactory.Reports.Base;
using AbstractFactory.Reports.Bodyes;
using AbstractFactory.Reports.Formatters;

namespace AbstractFactory.Reports.Factories;

public class PdfTableFactory : IReportFactory
{
    private readonly TableBody _tableBody = new();
    private readonly PdfFormatter _formatter = new();

    public byte[] GenerateReport()
    {
        _tableBody.BuildReportBody("Table");
        return _formatter.Format(_tableBody);
    }
}