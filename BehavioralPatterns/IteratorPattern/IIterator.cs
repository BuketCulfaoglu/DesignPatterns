namespace IteratorPattern;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
    T Current { get; }
}
