using System.Numerics;
using UtilsCSharp;

namespace UtilsCSharpTests.SortingTesting;

public class SortingTests
{
    #region BubbleSort

    [Test, TestOf("BubbleSort")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Sorting))]
    public void BubbleSort<T>(List<T> expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = Sorting.BubbleSort(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region SelectionSort

    [Test, TestOf("SelectionSort")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Sorting))]
    public void SelectionSort<T>(List<T> expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = Sorting.SelectionSort(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region InsertionSort

    [Test, TestOf("InsertionSort")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Sorting))]
    public void InsertionSort<T>(List<T> expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = Sorting.InsertionSort(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion
    
}