using AbstractFactoryPattern;

Console.WriteLine("New modern client...");
var modernClient = new Client(new ModernFurnitureFactory());
modernClient.SitAndRelax();

Console.WriteLine();
Console.WriteLine("New victorian client...");
var victorianClient = new Client(new VictorianFurnitureFactory());
victorianClient.SitAndRelax();
