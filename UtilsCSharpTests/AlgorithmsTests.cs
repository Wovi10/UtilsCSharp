using UtilsCSharp;

namespace UtilsCSharpTests;

public class AlgorithmsTests
{
    [SetUp]
    public void Setup()
    {
    }

    #region Cycle detection

    [Test]
    public void GetCycleLength_Short()
    {
        var list = new List<int> {1, 1,};
        var expected = 1;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Medium()
    {
        var list = new List<int> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5};
        var expected = 5;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Long()
    {
        var list = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
        };
        var expected = 20;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_BigNumbers()
    {
        var list = new List<int>
        {
            25, 12, 13,
            25, 12, 13
        };
        var expected = 3;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_NoCycle()
    {
        var list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
        var expected = 0;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_MoreCycles()
    {
        var list = new List<int> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5};
        var expected = 5;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void GetCycleLength_OddNumberedList()
    {
        var list = new List<int> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4};
        var expected = 5;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Long_Short()
    {
        var list = new List<long> {1, 1,};
        var expected = 1;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Long_Medium()
    {
        var list = new List<long> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5};
        var expected = 5;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Long_Long()
    {
        var list = new List<long>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
        };
        var expected = 20;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Long_BigNumbers()
    {
        var list = new List<long>
        {
            25, 12, 13,
            25, 12, 13
        };
        var expected = 3;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Long_NoCycle()
    {
        var list = new List<long> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
        var expected = 0;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Long_MoreCycles()
    {
        var list = new List<long> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5};
        var expected = 5;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void GetCycleLength_Long_OddNumberedList()
    {
        var list = new List<long> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4};
        var expected = 5;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    
    #endregion
}