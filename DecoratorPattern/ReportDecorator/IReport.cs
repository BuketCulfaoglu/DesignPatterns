namespace DecoratorPattern.ReportDecorator
{
    internal interface IReport
    {
        string GetReportName();
        string GetReportText();
        string GetReportTitle();
    }
}