using System.Collections.Generic;
using CustomList;

namespace CustomListTest;

[TestClass]
public class CustomListIntTest
{
    IList<int> customListInt = new CustomListInt
    {
        1,
        2,
        3,
        4,
        5
    };

    [TestMethod]
    public void Add_ShouldReturnCorrectResult()
    {
        customListInt.Add(6);
        var actual = customListInt.Count;
        const int expected = 6;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Insert_ShouldReturnCorrectResult()
    {
        customListInt.Insert(2, 10);
        var actual = customListInt[2];
        const int expected = 10;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Clear_ShouldReturnCorrectResult()
    {
        customListInt.Clear();
        var actual = customListInt.Count;
        const int expected = 0;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Contains_ShouldReturnCorrectResult()
    {
        var actual = customListInt.Contains(5);
        const bool expected = true;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IndexOf_ShouldReturnCorrectResult()
    {
        var actual = customListInt.IndexOf(1);
        const int expected = 0;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RemoveAt_ShouldReturnCorrectResult()
    {
        customListInt.RemoveAt(2);
        var actual = customListInt[2];
        const int expected = 4;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Remove_ShouldReturnCorrectResult()
    {
        customListInt.Remove(4);
        var actual = customListInt[3];
        const int expected = 5;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CopyTo_ShouldReturnCorrectResult()
    {
        var copyArray = new int[5];

        customListInt.CopyTo(copyArray, 0);
        var actual = copyArray[0];
        const int expected = 1;

        Assert.AreEqual(expected, actual);
    }
}