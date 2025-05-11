using AbstractFactory.Reports.Base;
using AbstractFactory.Reports.Bodyes;
using AbstractFactory.Reports.Formatters;

namespace AbstractFactory.Reports.Factories;

public class HtmlChartFactory : IReportFactory
{
    public IReportBody CreateReportBody() => new ChartBody();
    public IReportFormatter CreateReportFormatter() => new HtmlFormatter();
}