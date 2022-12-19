using System.Collections;

namespace CustomListTest;

[TestClass]
public class IndexOfTest
{
    [TestMethod]
    public void IndexOf_ShouldReturnCorrectResult()
    {
        IList customList = new CustomList.CustomList{"Tom","Jerry","Mery"};

        var actual = customList.IndexOf("Tom");
        const int expected = 0;
        
        Assert.AreEqual(expected, actual);
    }
}