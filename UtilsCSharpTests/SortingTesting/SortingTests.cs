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
        var actual = list.BubbleSort();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region SelectionSort

    [Test, TestOf("SelectionSort")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Sorting))]
    public void SelectionSort<T>(List<T> expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = list.SelectionSort();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region InsertionSort

    [Test, TestOf("InsertionSort")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Sorting))]
    public void InsertionSort<T>(List<T> expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = list.InsertionSort();
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

    # region ShellSort

    [Test, TestOf("ShellSort")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Sorting))]
    public void ShellSort<T>(List<T> expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = list.ShellSort();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Cocktail sort

    [Test, TestOf("CocktailSort")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Sorting))]
    public void CocktailSort<T>(List<T> expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = list.CocktailSort();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region BrickSort

    [Test, TestOf("BrickSort")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Sorting))]
    public void BrickSort<T>(List<T> expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = list.BrickSort();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region CombSort

    [Test, TestOf("CombSort")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Sorting))]
    public void CombSort<T>(List<T> expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = list.CombSort();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region GnomeSort

    [Test, TestOf("GnomeSort")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Sorting))]
    public void GnomeSort<T>(List<T> expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = list.GnomeSort();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region QuickSort

    [Test, TestOf("QuickSort")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Sorting))]
    public void QuickSort<T>(List<T> expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = list.QuickSort();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion
    
    #region HeapSort
    
    [Test, TestOf("HeapSort")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Sorting))]
    public void HeapSort<T>(List<T> expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = list.HeapSort();
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    #endregion

    #region SmoothSort
    
    [Test, TestOf("SmoothSort")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Sorting))]
    public void SmoothSort<T>(List<T> expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = list.SmoothSort();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region CartesianTreeSort
    
    [Test, TestOf("CartesianTreeSort")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Sorting))]
    public void CartesianTreeSort<T>(List<T> expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = list.CartesianTreeSort();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion
}