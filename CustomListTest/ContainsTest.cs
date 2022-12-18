using System.Collections;

namespace CustomListTest;

[TestClass]
public class ContainsTest
{
    [TestMethod]
    public void Contains_ShouldReturnCorrectResult()
    {
        IList customList = new CustomList.CustomList{1,2,3,4,5};
        
        var actual= customList.Contains(2);
        const bool expected = true;
        
        Assert.AreEqual(expected, actual);
    }
}