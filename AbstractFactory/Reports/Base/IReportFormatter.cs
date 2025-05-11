namespace AbstractFactory.Reports.Base;

public interface IReportFormatter
{
    byte [] Format (IReportBody reportBody);
}