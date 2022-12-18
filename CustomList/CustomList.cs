using System.Collections;

namespace CustomList;

public class CustomList: IList
{
    private readonly object?[] _array = new object?[10];
    private int _count;
    public CustomList()
    {
        _count = 0;
    }
    public int Add(object? value)
    {
        if (_count < _array.Length)
        {
            _array[_count] = value;
            _count++;
            
            return (_count - 1);
        }
        return -1;
        
    }

    public void Insert(int index, object? value)
    {
        if ((_count + 1 <= _array.Length) && (index < _count) && (index >= 0))
        {
            _count++;
            for (var i = _count - 1; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = value;
        }
    }
    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public void CopyTo(Array array, int index)
    {
        throw new NotImplementedException();
    }

    public int Count => _count;
    public bool IsSynchronized { get; }
    public object SyncRoot { get; }
    
    public void Clear()
    {
        _count = 0;
    }

    public bool Contains(object? value)
    {
        throw new NotImplementedException();
    }

    public int IndexOf(object? value)
    {
        for (var i = 0; i < _count; i++)
            if (_array[i] == value)
                return i;
        return -1;
    }
    public void Remove(object? value)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public bool IsFixedSize { get; }
    public bool IsReadOnly { get; }

    public object? this[int index]
    {
        get => _array[index];
        set => _array[index] = value;
    }
}