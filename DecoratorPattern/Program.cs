using DecoratorPattern.CoffeeDecorator;
using DecoratorPattern.ReportDecorator;

ICoffee coffee = new SimpleCoffee();
coffee = new Milk(coffee);
coffee = new Sugar(coffee);

Console.WriteLine(coffee.GetDescription());
Console.WriteLine(coffee.GetCost().ToString("0.00"));

Console.WriteLine("----------------------------");


IReport report = new SimpleReport("LoremIpsumReport", "Lorem Ipsum Title",
    "\nLorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's " +
    "\nstandard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. " +
    "\nIt has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
    "\nIt was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently " +
    "\nwith desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum");


report = new StripedReport(report);
Console.WriteLine("---------- STRIPED --------");
Console.WriteLine(report.GetReportTitle());
Console.WriteLine(report.GetReportText());


report = new SignedReport(report);
Console.WriteLine("---------- SIGNED --------");
Console.WriteLine(report.GetReportTitle());
Console.WriteLine(report.GetReportText());


report = new NarrowSpaceReport(report);
Console.WriteLine("---------- NARROW --------");
Console.WriteLine(report.GetReportTitle());
Console.WriteLine(report.GetReportText());



