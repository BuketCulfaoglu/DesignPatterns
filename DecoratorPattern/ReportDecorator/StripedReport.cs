using System.Text;

namespace DecoratorPattern.ReportDecorator
{
    internal class StripedReport : ReportDecorator
    {
        public StripedReport(IReport decoratedReport) : base(decoratedReport)
        {
        }

        public override string GetReportTitle()
        {
            return base.GetReportTitle() + " | Striped";
        }

        public override string GetReportText()
        {
            string baseReport = base.GetReportText();
            StringBuilder newReport = new StringBuilder();

            string[] reportLines = baseReport.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in reportLines)
            {
                if (line.Trim().Length > 0)
                    newReport.Append("\n  - " + line);
                else newReport.Append("\n");
            }

            return newReport.ToString();
        }
    }
}
