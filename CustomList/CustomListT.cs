using System.Collections;

namespace CustomList;

public class CustomList<T>: IList<T>
{
    private T[] _array = Array.Empty<T>();

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
}