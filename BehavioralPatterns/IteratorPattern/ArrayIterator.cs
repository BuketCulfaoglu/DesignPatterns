namespace IteratorPattern;

public class ArrayIterator<T> : IIterator<T>
{
    private readonly T[] _items;
    private int _position;

    public ArrayIterator(T[] items)
    {
        _items = items;
        _position = 0;
    }

    public bool HasNext()
    {
        return _position < _items.Length;
    }

    public T Next()
    {
        return _items[_position++];
    }

    public T Current => _items[_position];

}