using System.Collections;

namespace CustomListTest;

[TestClass]
public class ContainsTest
{
    [TestMethod]
    public void Contains_ShouldReturnCorrectResult()
    {
        IList customList = new CustomList.CustomList{"Tom","Jerry","Mery"};
        
        var actual= customList.Contains("Mery");
        const bool expected = true;
        
        Assert.AreEqual(expected, actual);
    }
}