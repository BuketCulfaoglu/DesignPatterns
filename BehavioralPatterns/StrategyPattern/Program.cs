using StrategyPattern;

List<int> numbers = new List<int> { 5, 3, 8, 4, 2 };

SortContext context = new SortContext();

context.SetSortStrategy(new BubbleSort());
context.SortList(numbers);
Console.WriteLine(string.Join(", ", numbers));

numbers = new List<int> { 5, 3, 8, 4, 2 };

context.SetSortStrategy(new QuickSort());
context.SortList(numbers);
Console.WriteLine(string.Join(", ", numbers));
