using System.Numerics;
using UtilsCSharp;

namespace UtilsCSharpTests.AlgorithmTesting;

public class AlgorithmsTests
{
    [SetUp]
    public void Setup()
    {
    }

    #region Cycle detection

    [Test, TestOf("GetLoopLength")]
    [TestCaseSource(typeof(TestData), nameof(TestData.GetLoopLength))]
    public void GetCycleLength<T>(T expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    #endregion
    
    #region BubbleSort
    
    // [Test]
    // public void BubbleSort_Int()
    // {
    //     var list = new List<int> {5, 3, 1, 4, 2};
    //     var expected = new List<int> {1, 2, 3, 4, 5};
    //     var actual = Algorithms<int>.BubbleSort(list);
    //     Assert.That(actual, Is.EqualTo(expected));
    // }
    
    #endregion
}