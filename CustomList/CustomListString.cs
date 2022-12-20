using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomList;

public class CustomListString : IList<string>
{
    private string[] _array = Array.Empty<string>();

    public IEnumerator<string> GetEnumerator()
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

    public void Add(string item)
    {
        Insert(_array.Length, item);
    }

    public void Clear()
    {
        var newArray = Array.Empty<string>();
        _array = newArray;
    }

    public bool Contains(string item)
    {
        return _array.Any(a => a == item);
    }

    public void CopyTo(string[] array, int arrayIndex)
    {
        foreach (var t in _array)
        {
            array.SetValue(t, arrayIndex);
            arrayIndex++;
        }
    }

    public bool Remove(string item)
    {
        var newArray = new string[_array.Length - 1];
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

    public int IndexOf(string item)
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

    public void Insert(int index, string item)
    {
        var newArray = new string[_array.Length + 1];
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
        var newArray = new string[_array.Length - 1];
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

    public string this[int index]
    {
        get => _array[index];
        set => _array[index] = value;
    }
}