using System.Collections;

namespace CustomListTest;

[TestClass]
public class ClearTest
{
    [TestMethod]
    public void Clear_ShouldReturnCorrectResult()
    {
        IList customList = new CustomList.CustomList{1,2,3,4,5};
        
        customList.Clear();
        var actual = customList.Count;
        const int expected = 0;
        
        Assert.AreEqual(expected, actual);
    }
}