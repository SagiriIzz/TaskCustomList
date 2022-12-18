using System.Collections;

namespace CustomListTest;

[TestClass]
public class IndexOfTest
{
    [TestMethod]
    public void IndexOf_ShouldReturnCorrectResult()
    {
        IList customList = new CustomList.CustomList{1,2,3,4,5};
        
        var actual = customList.IndexOf(2);
        const int expected = 1;
        
        Assert.AreEqual(expected, actual);
    }
}