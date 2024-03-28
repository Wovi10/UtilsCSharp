using UtilsCSharp;

namespace UtilsCSharpTests;

public class AlgorithmsTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetCycleLengthTest_Short()
    {
        var list = new List<int> {1, 1,};
        var expected = 1;
        var actual = Algorithms.GetCycleLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLengthTest_Medium()
    {
        var list = new List<int> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5};
        var expected = 5;
        var actual = Algorithms.GetCycleLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLengthTest_Long()
    {
        var list = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
        };
        var expected = 20;
        var actual = Algorithms.GetCycleLength(list);
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
        var actual = Algorithms.GetCycleLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_NoCycle()
    {
        var list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
        var expected = 0;
        var actual = Algorithms.GetCycleLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_MoreCycles()
    {
        var list = new List<int> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5};
        var expected = 5;
        var actual = Algorithms.GetCycleLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
}