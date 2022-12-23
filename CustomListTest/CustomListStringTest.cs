using System.Collections;
using CustomList;

namespace CustomListTest;

[TestClass]
public class CustomListStringTest
{
    private readonly IList<string> _customList = new CustomList<string>
    {
        "Oliver",
        "Jack",
        "Harry",
        "Jacob",
        "Charley"
    };

    private readonly IList _customListObj = new CustomList<object>
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
        _customList.Add("Thomas");
        var actual = _customList.Count;
        const int expected = 6;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Insert_ShouldReturnCorrectResult()
    {
        _customList.Insert(2, "Thomas");
        var actual = _customList[2];
        const string expected = "Thomas";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Clear_ShouldReturnCorrectResult()
    {
        _customList.Clear();
        var actual = _customList.Count;
        const int expected = 0;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Contains_ShouldReturnCorrectResult()
    {
        var actual = _customList.Contains("Oliver");
        const bool expected = true;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IndexOf_ShouldReturnCorrectResult()
    {
        var actual = _customList.IndexOf("Oliver");
        const int expected = 0;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RemoveAt_ShouldReturnCorrectResult()
    {
        _customList.RemoveAt(2);
        var actual = _customList[2];
        const string expected = "Jacob";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Remove_ShouldReturnCorrectResult()
    {
        _customList.Remove("Jacob");
        var actual = _customList[3];
        const string expected = "Charley";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CopyTo_ShouldReturnCorrectResult()
    {
        var copyArray = new string[5];

        _customList.CopyTo(copyArray, 0);
        var actual = copyArray[0];
        const string expected = "Oliver";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void AddObj_ShouldReturnCorrectResult()
    {
        var actual = _customListObj.Add("Thomas");
        const int expected = 5;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void InsertObj_ShouldReturnCorrectResult()
    {
        _customListObj.Insert(2, "Thomas");
        var actual = _customListObj[2];
        const string expected = "Thomas";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ContainsObj_ShouldReturnCorrectResult()
    {
        var actual = _customListObj.Contains("Oliver");
        const bool expected = true;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IndexOfObj_ShouldReturnCorrectResult()
    {
        var actual = _customListObj.IndexOf("Oliver");
        const int expected = 0;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RemoveObj_ShouldReturnCorrectResult()
    {
        _customListObj.Remove("Jacob");
        var actual = _customListObj[3];
        const string expected = "Charley";

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CopyToObj_ShouldReturnCorrectResult()
    {
        var copyArray = new string[5];

        _customListObj.CopyTo(copyArray, 0);
        var actual = copyArray[0];
        const string expected = "Oliver";

        Assert.AreEqual(expected, actual);
    }
}