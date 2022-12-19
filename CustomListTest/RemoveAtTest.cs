using System.Collections;

namespace CustomListTest;

[TestClass]
public class RemoveAtTest
{
    [TestMethod]
    public void RemoveAt_ShouldReturnCorrectResult()
    {
        IList customList = new CustomList.CustomList{1,2,3,4,5};
        
        customList.RemoveAt(2);
        var actual = customList[2];
        const int expected = 4;
        
        Assert.AreEqual(expected, actual);
    }
}