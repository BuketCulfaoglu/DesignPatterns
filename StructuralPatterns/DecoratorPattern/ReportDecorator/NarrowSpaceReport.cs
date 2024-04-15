using System.Text;

namespace DecoratorPattern.ReportDecorator
{
    internal class NarrowSpaceReport : ReportDecorator
    {
        public NarrowSpaceReport(IReport decoratedReport) : base(decoratedReport)
        {
        }

        public override string GetReportTitle()
        {
            return base.GetReportTitle() + " | NarrowSpace";
        }

        public override string GetReportText()
        {
            string baseReport = base.GetReportText();
            StringBuilder newReport = new StringBuilder();

            string[] reportLines = baseReport.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            int wordCount = 0;
            int wordLimit = 8;

            foreach (string line in reportLines)
            {
                string[] lineWords = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                newReport.AppendLine();

                foreach (string word in lineWords)
                {
                    newReport.Append(word + " ");
                    wordCount++;

                    if (wordCount >= wordLimit)
                    {
                        newReport.AppendLine();
                        wordCount = 0;
                    }
                }
            }

            return newReport.ToString();
        }
    }
}
