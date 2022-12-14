namespace TaskCustomList;

public class CustomList : IList
{

    public void Insert(ref int[] array, int value, int index)
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
    public void Add(ref int[] array, int value)
    {
        Insert(ref array, value, array.Length);
    }
    public void RemoveAt(ref int[] array, int index)
    {
        var newArray = new int[array.Length - 1];
        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }

        for (var i = index+1; i < array.Length; i++)
        {
            newArray[i-1] = array[i];
        }

        array = newArray;
    }

    public void Remove(ref int[] array, int value )
    {
        var newArray = new int[array.Length - 1];
        var index = IndexOf(ref array, value);

        for (var i = index+1; i < array.Length; i++)
        {
            newArray[i-1] = array[i];
        }

        array = newArray;
    }

    public void Clear(ref int[] array)
    {
        var newArray = new int[0];
        array = newArray;
    }

    public bool Contains(ref int[] array, int value)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var a = array[i];
            if (a == value)
            {
                return true;
            }
        }

        return false;
    }

    public int IndexOf(ref int[] array, int value)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var a = array[i];
            if (a == value)
            {
                return i;
            }
        }
        return -1;
    }
}