using System.Net.Http.Headers;

namespace DecoratorPattern.ReportDecorator
{
    internal abstract class ReportDecorator : IReport
    {
        protected readonly IReport _decoratedReport;

        protected ReportDecorator(IReport decoratedReport)
        {
            _decoratedReport = decoratedReport;
        }

        public string GetReportName()
        {
            return _decoratedReport.GetReportName();
        }

        public virtual string GetReportText()
        {
            return _decoratedReport.GetReportText();
        }

        public virtual string GetReportTitle()
        {
            return _decoratedReport.GetReportTitle();
        }
    }
}
