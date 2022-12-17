using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace TaskCustomList;

public class CustomList: IList
{
    public object?[] _array = new object?[10];
    private int _count;
    public CustomList(ref int[] array)
    {
        _count = 0;
    }
    public void Insert(int index, object? value)
    {
        var newArray = new int[array.Length +1];
        newArray[index] = value;
        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }

        for (var i = index; i < array.Length; i++)
        {
            newArray[i+1] = array[i];
        }

        array = newArray;
    }
    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public void CopyTo(Array array, int index)
    {
        throw new NotImplementedException();
    }

    public int Count { get; }
    public bool IsSynchronized { get; }
    public object SyncRoot { get; }

    public int Add(object? value)
    {
        if (_count < _array.Length)
        {
            _array[_count] = value;
            _count++;
            
            return (_count - 1);
        }
        else
        {
            return -1;
        }
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(object? value)
    {
        throw new NotImplementedException();
    }

    public int IndexOf(object? value)
    {
        throw new NotImplementedException();
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
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}