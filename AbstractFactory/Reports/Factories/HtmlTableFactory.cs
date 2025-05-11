using AbstractFactory.Reports.Base;
using AbstractFactory.Reports.Bodyes;
using AbstractFactory.Reports.Formatters;

namespace AbstractFactory.Reports.Factories;

public class HtmlTableFactory :IReportFactory
{
    public IReportBody CreateReportBody() => new TableBody();
    public IReportFormatter CreateReportFormatter() => new HtmlFormatter();
}