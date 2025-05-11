namespace AbstractFactory.Reports.Base;

public interface IReportFactory
{
    byte[] GenerateReport();
}