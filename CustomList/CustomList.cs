using System.Collections;

namespace CustomList;

public class CustomList: IList
{
    private object?[] _array = Array.Empty<object?>();
    public int Add(object? value)
    {
       Insert(_array.Length, value);
       return _array.Length - 1;
    }

    public void Insert(int index, object? value)
    {
        var newArray = new object?[_array.Length +1];
        newArray[index] = value;
        for (int i = 0; i < index; i++)
        {
            newArray[i] = _array[i];
        }

        for (var i = index; i < _array.Length; i++)
        {
            newArray[i+1] = _array[i];
        }

        _array = newArray;
    }
    public int IndexOf(object? value)
    {
        for (var i = 0; i < _array.Length; i++)
        {
            if ( _array[i] == value)
            {
                return i;
            }
        }
        return -1;
    }
    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public void CopyTo(Array array, int index)
    {
        throw new NotImplementedException();
    }

    public int Count => _array.Length;  
    public bool IsSynchronized { get; }
    public object SyncRoot { get; }
    
    public void Clear()
    {
        var newArray = Array.Empty<object?>();
        _array = newArray;
    }

    public bool Contains(object? value)
    {
        return _array.Any(a => a == value);
    }
    public void Remove(object? value)
    {

    }

    public void RemoveAt(int index)
    {
        var newArray = new object?[_array.Length - 1];
        for (var i = 0; i < index; i++)
        {
            newArray[i] = _array[i];
        }

        for (var i = index+1; i < _array.Length; i++)
        {
            newArray[i-1] = _array[i];
        }

        _array = newArray;
    }

    public bool IsFixedSize { get; }
    public bool IsReadOnly { get; }

    public object? this[int index]
    {
        get => _array[index];
        set => _array[index] = value;
    }
}