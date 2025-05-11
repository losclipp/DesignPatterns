using AbstractFactory.Reports.Base;
using AbstractFactory.Reports.Bodyes;
using AbstractFactory.Reports.Formatters;

namespace AbstractFactory.Reports.Factories;

public class FactoryGenerator
{
    public static IReportFactory GenerateReportFactory(FormatType formatType, BodyType bodyType)
    {
        if (formatType == FormatType.HTML && bodyType == BodyType.Table) 
            return new PdfTableFactory();
        if (formatType == FormatType.HTML && bodyType == BodyType.Chart)
            return new HtmlChartFactory();
        if (formatType == FormatType.PDF && bodyType == BodyType.Table)
            return new PdfTableFactory();
        if (formatType == FormatType.PDF && bodyType == BodyType.Chart)
            return new PdfChartFactory();
        throw new ArgumentOutOfRangeException("Unknown format or body type");
    }
}