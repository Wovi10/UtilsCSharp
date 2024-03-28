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
    public void GetCycleLength_Int_Short()
    {
        var list = new List<int> {1, 1, 2, 1, 1, 2, 1, 1, 2};
        var expected = 3;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Int_Medium()
    {
        var list = new List<int> {
            1, 2, 3, 4, 5, 
            1, 2, 3, 4, 5, 
            1, 2, 3, 4, 5
        };
        var expected = 5;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Int_Long()
    {
        var list = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
        };
        var expected = 20;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Int_BigNumbers()
    {
        var list = new List<int>
        {
            25, 12, 13,
            25, 12, 13,
            25, 12, 13
        };
        var expected = 3;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Int_NoCycle()
    {
        var list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
        var expected = 0;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Int_NoCycle2()
    {
        var list = new List<int> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 7, 1, 2, 3, 4, 5};
        var expected = 0;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Int_MoreCycles()
    {
        var list = new List<int> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5};
        var expected = 5;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Int_OddNumberedList()
    {
        var list = new List<int> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4};
        var expected = 5;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Int_MiddleOfList()
    {
        var list = new List<int> {0, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5};
        var expected = 5;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Long_Short()
    {
        var list = new List<long>
        {
            1, 1, 2,
            1, 1, 2,
            1, 1, 2
        };
        var expected = 3;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Long_Medium()
    {
        var list = new List<long>
        {
            1, 2, 3, 4, 5, 
            1, 2, 3, 4, 5, 
            1, 2, 3, 4, 5
        };
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
    public void GetCycleLength_Long_NoCycle2()
    {
        var list = new List<long> {1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 7, 1, 2, 3, 4, 5};
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

    [Test]
    public void GetCycleLength_Long_MiddleOfList()
    {
        var list = new List<long> {0, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5};
        var expected = 5;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void GetCycleLength_Int_ShortList()
    {
        var list = new List<int> {1, 2};
        var expected = 0;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void GetCycleLength_Long_ShortList()
    {
        var list = new List<long> {1, 2};
        var expected = 0;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Int_LongList()
    {
        var list = new List<int>();
        for (var j = 0; j < 2; j++)
        {
            for (var i = 0; i < 201; i++)
            {
                list.Add(i);
            }
        }
        
        var expected = 0;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetCycleLength_Long_LongList()
    {
        var list = new List<long>();
        for (var j = 0; j < 2; j++)
        {
            for (var i = 0; i < 201; i++)
            {
                list.Add(i);
            }
        }
        
        var expected = 0;
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    #endregion
}