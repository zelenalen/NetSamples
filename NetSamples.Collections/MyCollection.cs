using System.Collections;

namespace NetSamples.Collections;

public class MyCollection<T> : IEnumerable<T>
{
    private List<T> values;
    public IEnumerator<T> GetEnumerator()
    {
        return values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class MyEnumerator<T> : IEnumerator<T>
{
    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }

    public T Current { get; }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}