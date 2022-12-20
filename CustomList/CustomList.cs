using System.Collections;

namespace CustomList;

public class CustomList : IList
{
    private object?[] _array = Array.Empty<object?>();

    public int Add(object? value)
    {
        Insert(_array.Length, value);
        return _array.Length - 1;
    }

    public void Insert(int index, object? value)
    {
        var newArray = new object?[_array.Length + 1];
        newArray[index] = value;
        for (var i = 0; i < index; i++)
        {
            newArray[i] = _array[i];
        }

        for (var i = index; i < _array.Length; i++)
        {
            newArray[i + 1] = _array[i];
        }

        _array = newArray;
    }

    public int IndexOf(object? value)
    {
        for (var i = 0; i < _array.Length; i++)
        {
            if (_array[i] == value)
            {
                return i;
            }
        }

        return -1;
    }

    public IEnumerator GetEnumerator()
    {
        foreach (var t in _array)
        {
            yield return t;
        }
    }

    public void CopyTo(Array array, int index)
    {
        foreach (var t in _array)
        {
            array.SetValue(t, index);
            index++;
        }
    }

    public int Count => _array.Length;
    public bool IsSynchronized => false;
    public object SyncRoot => null;


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
        var newArray = new object?[_array.Length - 1];
        var index = IndexOf(value);

        for (var i = index + 1; i < _array.Length; i++)
        {
            newArray[i - 1] = _array[i];
        }

        _array = newArray;
    }

    public void RemoveAt(int index)
    {
        var newArray = new object?[_array.Length - 1];
        for (var i = 0; i < index; i++)
        {
            newArray[i] = _array[i];
        }

        for (var i = index + 1; i < _array.Length; i++)
        {
            newArray[i - 1] = _array[i];
        }

        _array = newArray;
    }

    public bool IsFixedSize => true;
    public bool IsReadOnly => false;

    public object? this[int index]
    {
        get => _array[index];
        set => _array[index] = value;
    }
}