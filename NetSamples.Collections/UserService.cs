using System.Collections;

namespace NetSamples.Collections;

public class UserService : IList<User>
{
    private List<User> _users;

    public UserService(List<User> users)
    {
        _users = users;
    }

    public IEnumerator<User> GetEnumerator()
    {
        return _users.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(User item)
    {
        _users.Add(item);
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(User item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(User[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(User item)
    {
        throw new NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(User item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, User item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public User this[int index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}