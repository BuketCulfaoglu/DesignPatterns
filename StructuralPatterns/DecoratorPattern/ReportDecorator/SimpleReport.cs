namespace DecoratorPattern.ReportDecorator
{
    internal class SimpleReport : IReport
    {
        private readonly string _name;
        private readonly string _title;
        private readonly string _text;

        public SimpleReport(string name, string title, string text)
        {
            _name = name;
            _title = title;
            _text = text;
        }

        public string GetReportName()
        {
            return _name;
        }

        public string GetReportTitle()
        {
            return _title;
        }

        public string GetReportText()
        {
            return _text;
        }
    }
}
