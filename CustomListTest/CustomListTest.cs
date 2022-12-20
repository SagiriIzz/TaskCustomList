using System.Collections;

namespace CustomListTest;

[TestClass]
public class CustomListTest
{
    IList customList = new CustomList.CustomList
    {
        "Oliver",
        "Jack",
        "Harry",
        "Jacob",
        "Charley"
    };

    [TestMethod]
    public void Add_ShouldReturnCorrectResult()
    {
        var actual = customList.Add("Thomas");
        const int expected = 5;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Insert_ShouldReturnCorrectResult()
    {
        customList.Insert(2, "Thomas");
        var actual = customList[2];
        const string expected = "Thomas";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Clear_ShouldReturnCorrectResult()
    {
        customList.Clear();
        var actual = customList.Count;
        const int expected = 0;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Contains_ShouldReturnCorrectResult()
    {
        var actual = customList.Contains("Oliver");
        const bool expected = true;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IndexOf_ShouldReturnCorrectResult()
    {
        var actual = customList.IndexOf("Oliver");
        const int expected = 0;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RemoveAt_ShouldReturnCorrectResult()
    {
        customList.RemoveAt(2);
        var actual = customList[2];
        const string expected = "Jacob";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Remove_ShouldReturnCorrectResult()
    {
        customList.Remove("Jacob");
        var actual = customList[3];
        const string expected = "Charley";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CopyTo_ShouldReturnCorrectResult()
    {
        var copyArray = new string[5];

        customList.CopyTo(copyArray, 0);
        var actual = copyArray[0];
        const string expected = "Oliver";

        Assert.AreEqual(expected, actual);
    }
}