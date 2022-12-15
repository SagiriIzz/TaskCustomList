using TaskCustomList;

namespace TaskCustomListTests;

[TestClass]
public class InsertTest
{
    [TestMethod]
    public void Insert_ShouldReturnCorrectResult()
    {
        int[] myArray = { 1, 4, 6, 2};
        IListCustom customList = new RefCustomList();
        
        customList.Insert(ref myArray, 10, 1);
        var actual = myArray[1];
        const int expected = 10;
        
        Assert.AreEqual(expected, actual);
    }
}