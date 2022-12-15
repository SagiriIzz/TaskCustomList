namespace TaskCustomList;

public interface IListCustom
{
    void Add(ref int[] array, int value);
    void Clear(ref int[] array);
    bool Contains(ref int[] array, int value);
    int IndexOf(ref int[] array, int value);
    void Insert(ref int[] array, int value, int index);
    void Remove(ref int[] array, int value);
   void RemoveAt(ref int[] array, int index);
}