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
    
    #region Merge
    
    [Test, TestOf("Merge")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MergeCases))]
    public void Merge<T>(List<T> expected, List<T> listA, List<T> listB) where T : struct, INumber<T>
    {
        var actual = listA.MergeInto(listB);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    #endregion
}