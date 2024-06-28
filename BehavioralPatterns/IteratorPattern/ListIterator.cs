namespace IteratorPattern;

public class ListIterator<T> : IIterator<T>
{
    private readonly List<T> _items;
    private int _position;

    public ListIterator(List<T> items)
    {
        _items = items;
    }


    public bool HasNext()
    {
        return _position < _items.Count;
    }

    public T Next()
    {
        return (T)_items[_position++];
    }

    public T Current => _items[_position];
}