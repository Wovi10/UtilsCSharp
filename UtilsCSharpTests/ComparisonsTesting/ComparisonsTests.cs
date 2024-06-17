using System.Numerics;
using UtilsCSharp;

namespace UtilsCSharpTests.ComparisonsTesting;

public class ComparisonsTests
{
    #region GetHighest

    [Test, TestOf("GetHighest")]
    [TestCaseSource(typeof(TestData), nameof(TestData.GetHighest))]
    public void GetHighest<T>(T expected, T first, T second) where T : struct, INumber<T>
    {
        var actual = Comparisons.GetHighest(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region GetLowest

    [Test, TestOf("GetLowest")]
    [TestCaseSource(typeof(TestData), nameof(TestData.GetLowest))]
    public void GetLowest<T>(T expected, T first, T second) where T : struct, INumber<T>
    {
        var actual = Comparisons.GetLowest(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsEven

    [Test, TestOf("IsEven")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsEven))]
    public void IsEven<T>(bool expected, T first) where T : struct, INumber<T>
    {
        var actual = first.IsEven();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsOdd

    [Test, TestOf("IsOdd")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsOdd))]
    public void IsOdd<T>(bool expected, T first) where T : struct, INumber<T>
    {
        var actual = first.IsOdd();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsGreaterThan

    [Test, TestOf("IsGreaterThan")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsGreaterThan))]
    public void IsGreaterThan<T>(bool? expected, T first, T second) where T : struct, INumber<T>
    {
        var actual = first.IsGreaterThan(second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsGreaterThan))]
    public void IsBiggerThan<T>(bool? expected, T first, T second) where T : struct, INumber<T>
    {
        var actual = first.IsBiggerThan(second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsLessThan

    [Test, TestOf("IsLessThan")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsSmallerThan))]
    public void IsLessThan<T>(bool? expected, T first, T second) where T : struct, INumber<T>
    {
        var actual = first.IsLessThan(second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("IsSmallerThan")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsSmallerThan))]
    public void IsSmallerThan<T>(bool? expected, T first, T second) where T : struct, INumber<T>
    {
        var actual = first.IsSmallerThan(second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsGreaterThanOrEqualTo

    [Test, TestOf("IsGreaterThanOrEqualTo")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsGreaterThanOrEqualTo))]
    public void IsGreaterThanOrEqualTo<T>(bool expected, T first, T second) where T : struct, INumber<T>
    {
        var actual = first.IsGreaterThanOrEqualTo(second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsLessThanOrEqualTo

    [Test, TestOf("IsLessThanOrEqualTo")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsLessThanOrEqualTo))]
    public void IsLessThanOrEqualTo<T>(bool expected, T first, T second) where T : struct, INumber<T>
    {
        var actual = first.IsLessThanOrEqualTo(second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    # region IsBetween

    [Test, TestOf("IsBetween")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsBetween))]
    public void IsBetween<T>(bool expected, T first, T lower, T upper, bool lowerInclusive, bool upperInclusive) where
        T : struct, INumber<T>
    {
        var actual = first.IsBetween(lower, upper, lowerInclusive, upperInclusive);
        Assert.That(actual, Is.EqualTo(expected));
    }

    # endregion
}