using TaskCustomList;

namespace TaskCustomListTests;

[TestClass]
public class RemoveAtTest
{
    [TestMethod]
    public void RemoveAt_ShouldReturnCorrectResult()
    {
        int[] myArray = { 1, 4, 6, 2};
        IListCustom customList = new RefCustomList();
        
        customList.RemoveAt(ref myArray, 2);
        var actual = myArray.Length;
        const int expected = 3;
        
        Assert.AreEqual(expected, actual);
    }
}