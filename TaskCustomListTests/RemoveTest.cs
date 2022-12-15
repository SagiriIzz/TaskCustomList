using TaskCustomList;

namespace TaskCustomListTests;

[TestClass]
public class RemoveTest
{
    [TestMethod]
    public void Remove_ShouldReturnCorrectResult()
    {
        int[] myArray = { 1, 4, 6, 2};
        IListCustom customList = new RefCustomList();
        
        customList.Remove(ref myArray, 4);
        var actual = myArray.Length;
        const int expected = 3;
        
        Assert.AreEqual(expected, actual);
    }
}