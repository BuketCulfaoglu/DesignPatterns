namespace IteratorPattern;

public class ArrayAggregate<T> : IAggregate<T>
{
    private readonly T[] _items;

    public ArrayAggregate(T[] items)
    {
        _items = items;
    }

    public IIterator<T> CreateIterator()
    {
        return new ArrayIterator<T>(_items);
    }
}