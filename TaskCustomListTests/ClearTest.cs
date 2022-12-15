using TaskCustomList;

namespace TaskCustomListTests;

[TestClass]
public class ClearTest
{
    [TestMethod]
    public void Clear_ReturnCorrectResult()
    {
        int[] myArray = { 1, 4, 6, 2};
        IListCustom customList = new RefCustomList();
        
        customList.Clear(ref myArray);
        var actual = myArray.Length;
        const int expected =0;
        
        Assert.AreEqual(expected, actual);
    }
}