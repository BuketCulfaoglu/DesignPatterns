namespace IteratorPattern;

public class ListAggregate<T> : IAggregate<T>
{
    private readonly List<T> _items;

    public ListAggregate(List<T> items)
    {
        _items = items;
    }

    public IIterator<T> CreateIterator()
    {
        return new ListIterator<T>(_items);
    }
}