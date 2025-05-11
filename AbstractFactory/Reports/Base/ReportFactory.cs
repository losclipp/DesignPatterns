namespace AbstractFactory.Reports.Base;

public interface IReportFactory
{
    IReportBody CreateReportBody();
    IReportFormatter CreateReportFormatter();
}