using System.Collections;

namespace CustomList;

public class CustomList<T> : IList, IList<T>
{
    //Ilist<T>
    private T[] _array = Array.Empty<T>();
    private object?[] _arrayObject = Array.Empty<object?>();

    public void Add(T item)
    {
        Insert(_array.Length, item);
    }

    public void Insert(int index, T item)
    {
        var newArray = new T[_array.Length + 1];
        newArray[index] = item;
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

    public void Clear()
    {
        var newArray = Array.Empty<T>();
        _array = newArray;
    }

    public bool Contains(T item)
    {
        foreach (var a in _array)
        {
            if (Equals(a, item)) return true;
        }

        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        foreach (var t in _array)
        {
            array.SetValue(t, arrayIndex);
            arrayIndex++;
        }
    }

    public bool Remove(T item)
    {
        var newArray = new T[_array.Length - 1];
        var index = IndexOf(item);

        for (var i = index + 1; i < _array.Length; i++)
        {
            newArray[i - 1] = _array[i];
        }

        _array = newArray;

        return index != -1;
    }

    public int Count => _array.Length;
    public bool IsReadOnly => false;

    public int IndexOf(T item)
    {
        for (var i = 0; i < _array.Length; i++)
        {
            if (Equals(_array[i], item))
            {
                return i;
            }
        }

        return -1;
    }

    public void RemoveAt(int index)
    {
        var newArray = new T[_array.Length - 1];
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

    public T this[int index]
    {
        get => _array[index];
        set => _array[index] = value;
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var t in _array)
        {
            yield return t;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    //Ilist
    public int Add(object? value)
    {
        Insert(_arrayObject.Length, value);
        return _arrayObject.Length - 1;
    }

    public bool Contains(object? value)
    {
        return _arrayObject.Any(a => a == value);
    }

    public int IndexOf(object? value)
    {
        for (var i = 0; i < _arrayObject.Length; i++)
        {
            if (_arrayObject[i] == value)
            {
                return i;
            }
        }

        return -1;
    }

    public void Insert(int index, object? value)
    {
        var newArray = new object?[_arrayObject.Length + 1];
        newArray[index] = value;
        for (var i = 0; i < index; i++)
        {
            newArray[i] = _arrayObject[i];
        }

        for (var i = index; i < _arrayObject.Length; i++)
        {
            newArray[i + 1] = _arrayObject[i];
        }

        _arrayObject = newArray;
    }

    public void Remove(object? value)
    {
        var newArray = new object?[_arrayObject.Length - 1];
        var index = IndexOf(value);

        for (var i = index + 1; i < _arrayObject.Length; i++)
        {
            newArray[i - 1] = _arrayObject[i];
        }

        _arrayObject = newArray;
    }

    public void CopyTo(Array array, int index)
    {
        foreach (var t in _arrayObject)
        {
            array.SetValue(t, index);
            index++;
        }
    }

    public bool IsSynchronized => false;
    public object SyncRoot => false;
    public bool IsFixedSize => true;

    object? IList.this[int index]
    {
        get => _arrayObject[index];
        set => _arrayObject[index] = value;
    }
}