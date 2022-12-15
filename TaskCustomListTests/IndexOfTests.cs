using TaskCustomList;

namespace TaskCustomListTests;

[TestClass]
public class IndexOfTest
{
    [TestMethod]
    public void IndexOf_ShouldReturnCorrectResult()
    {
        int[] myArray = { 1, 4, 6, 2};
        IListCustom customList = new RefCustomList();
        
        var actual = customList.IndexOf(ref myArray,  6);
        const int expected = 2;
        
        Assert.AreEqual(expected, actual);
    }
}