using System.Collections;

namespace CustomList;

public class CustomListInt : IList<int>
{
    private int[] _array = Array.Empty<int>();

    public IEnumerator<int> GetEnumerator()
    {
        foreach (var t in _array)
        {
            yield return t;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        foreach (var t in _array)
        {
            yield return t;
        }
    }

    public void Add(int item)
    {
        Insert(_array.Length, item);
    }

    public void Clear()
    {
        var newArray = Array.Empty<int>();
        _array = newArray;
    }

    public bool Contains(int item)
    {
        return _array.Any(a => a == item);
    }

    public void CopyTo(int[] array, int arrayIndex)
    {
        foreach (var t in _array)
        {
            array.SetValue(t, arrayIndex);
            arrayIndex++;
        }
    }

    public bool Remove(int item)
    {
        var newArray = new int[_array.Length - 1];
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

    public int IndexOf(int item)
    {
        for (var i = 0; i < _array.Length; i++)
        {
            if (_array[i] == item)
            {
                return i;
            }
        }

        return -1;
    }

    public void Insert(int index, int item)
    {
        var newArray = new int[_array.Length + 1];
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

    public void RemoveAt(int index)
    {
        var newArray = new int[_array.Length - 1];
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

    public int this[int index]
    {
        get => _array[index];
        set => _array[index] = value;
    }
}