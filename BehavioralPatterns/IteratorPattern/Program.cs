using IteratorPattern;

// Array example
int[] numbersArray = { 1, 2, 3, 4, 5 };
IAggregate<int> arrayAggregate = new ArrayAggregate<int>(numbersArray);
IIterator<int> arrayIterator = arrayAggregate.CreateIterator();

Console.WriteLine("Iterating over array:");
while (arrayIterator.HasNext())
{
    Console.WriteLine(arrayIterator.Next());
}


// List example
List<int> numbersList = new List<int> { 6, 7, 8, 9, 10 };
IAggregate<int> listAggregate = new ListAggregate<int>(numbersList);
IIterator<int> listIterator = listAggregate.CreateIterator();

Console.WriteLine("Iterating over list:");
while (listIterator.HasNext())
{
    Console.WriteLine(listIterator.Next());
}