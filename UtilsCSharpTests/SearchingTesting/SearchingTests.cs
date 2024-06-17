using UtilsCSharp;

namespace UtilsCSharpTests.SearchingTesting;

public class SearchingTests
{
    [Test, TestOf(nameof(Searching.BinarySearch))]
    [TestCaseSource(typeof(TestData), nameof(TestData.BinarySearchCases))]
    public void BinarySearchTest<T>(int expected, IEnumerable<T> input, T searchKey)
        where T : struct, IComparable<T>
    {
        var actual = input.BinarySearch(searchKey);
        Assert.That(actual, Is.EqualTo(expected));
    }
}