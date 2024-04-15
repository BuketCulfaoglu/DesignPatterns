namespace DecoratorPattern.ReportDecorator
{
    internal class SignedReport : ReportDecorator
    {
        public SignedReport(IReport decoratedReport) : base(decoratedReport)
        {
        }

        public override string GetReportTitle()
        {
            return base.GetReportTitle() + " | Signed";
        }
        public override string GetReportText()
        {
            return base.GetReportText() + "\n\n" + "\t\tSignuture : ";
        }
    }
}
