using TaskCustomList;

namespace TaskCustomListTests;

[TestClass]
public class ContainsTest
{
    [TestMethod]
    public void Contains_ShouldReturnTrue()
    {
        int[] myArray = { 1, 4, 6, 2};
        IListCustom customList = new RefCustomList();
        
        var actual = customList.Contains(ref myArray, 6);;
        const bool expected = true;
        
        Assert.AreEqual(expected, actual);
    }
}