using System.Collections;

namespace CustomListTest;

[TestClass]
public class AddTest
{
    [TestMethod]
    public void Add_ShouldReturnCorrectResult()
    {
        IList customList = new CustomList.CustomList{1,2,3,4,5};

        var actual= customList.Add(2);
        const int expected = 5;
        
        Assert.AreEqual(expected, actual);
    }
}