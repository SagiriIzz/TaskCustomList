using TaskCustomList;

namespace TaskCustomListTests;

[TestClass]
public class AddTest
{
    [TestMethod]
    public void Add_ShouldReturnCorrectResult()
    {
        int[] myArray = { 1, 4, 6, 2};
        IList customList = new CustomList();
        
        customList.Add(ref myArray,  10);
        var actual = myArray[4];
        const int expected = 10;
        
        Assert.AreEqual(expected, actual);
    }
}