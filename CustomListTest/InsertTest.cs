using System.Collections;

namespace CustomListTest;

[TestClass]
public class InsertTest
{
    [TestMethod]
    public void Insert_ShouldReturnCorrectResult()
    {
        IList customList = new CustomList.CustomList{1,2,3,4,5};
        
        customList.Insert(2, 10);
        var actual = customList[2];
        const int expected = 10;
        
        Assert.AreEqual(expected, actual);
    }
}