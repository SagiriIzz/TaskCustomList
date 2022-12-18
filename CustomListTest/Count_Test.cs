using System.Collections;

namespace CustomListTest;

[TestClass]
public class CountTest
{
    [TestMethod]
    public void Count_ShouldReturnCorrectResult()
    {
        IList customList = new CustomList.CustomList{1,2,3,4,5};
        
        var actual = customList.Count;
        const int expected = 5;
        
        Assert.AreEqual(expected, actual);
    }
}