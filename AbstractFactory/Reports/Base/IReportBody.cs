namespace AbstractFactory.Reports.Base;

public interface IReportBody
{
    
    void BuildReportBody(string reportBody);
    string Content { get;}
}