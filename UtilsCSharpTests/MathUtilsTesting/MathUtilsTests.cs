using System.Numerics;
using UtilsCSharp;

namespace UtilsCSharpTests.MathUtilsTesting;

[TestFixture]
public class MathUtilsTests
{
    [SetUp]
    public void Setup()
    {
    }

    #region Add

    [Test, TestOf("Add")]
    [TestCaseSource(typeof(TestData), nameof(TestData.AddCasesNumbers))]
    public void Add<T>(T expected, T first, T second) where T : struct, INumber<T>
    {
        var actual = first.Add(second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Add")]
    [TestCaseSource(typeof(TestData), nameof(TestData.AddCasesEnumerable))]
    public void Add<T>(T expected, IEnumerable<T> numbers, T seed, T constant) where T : struct, INumber<T>
    {
        var actual = MathUtils.Add(numbers, seed, constant);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Subtract

    [Test, TestOf("Subtract")]
    [TestCaseSource(typeof(TestData), nameof(TestData.SubtractCasesNumbers))]
    public void Subtract<T>(T expected, T first, T second, int? precision = null) where T : struct, INumber<T>
    {
        var actual = first.Sub(second, precision);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Multiply

    [Test, TestOf("Multiply")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MultiplyCasesNumbers))]
    public void Multiply<T>(T expected, T first, T second, int? precision = null) where T : struct, INumber<T>
    {
        var actual = first.Mul(second, precision);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Divide

    [Test, TestOf("Divide")]
    [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesNumbers))]
    public void Divide<T>(T expected, T first, T second, int? precision = null) where T : struct, INumber<T>
    {
        if (second != T.Zero)
        {
            var actual = first.Div(second, precision);
            Assert.That(actual, Is.EqualTo(expected));
        }
        else
            Assert.Throws<DivideByZeroException>(() => first.Div(second, precision));
    }

    #endregion

    #region Greatest Common Dividor

    [Test, TestOf("GCD")]
    [TestCaseSource(typeof(TestData), nameof(TestData.GcdCases))]
    public void Gcd<T>(T expected, T first, T second) where T : struct, INumber<T>
    {
        var actual = first.GcdWith(second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Least Common Multiple

    [Test, TestOf("LCM")]
    [TestCaseSource(typeof(TestData), nameof(TestData.LcmCases))]
    public void Lcm<T>(T expected, T first, T second) where T : struct, INumber<T>
    {
        var actual = first.Lcm(second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsPrime

    [Test, TestOf("IsPrime")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsPrime))]
    public void IsPrime<T>(bool expected, T first) where T : struct, INumber<T>
    {
        var actual = first.IsPrime();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Pythagorean Theorem

    [Test, TestOf("Pythagorean Theorem")]
    [TestCaseSource(typeof(TestData), nameof(TestData.PythagoreanTheorem))]
    public void PythagoreanTheorem<T>(T expected, T first, T second, int? precision = null) where T : struct, INumber<T>
    {
        var actual = MathUtils.PythagoreanTheorem(first, second, precision);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Discriminant

    [Test, TestOf("Discriminant")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Discriminant))]
    public void Discriminant<T>(T expected, T a, T b, T c, int? precision = null) where T : struct, INumber<T>
    {
        var actual = MathUtils.Discriminant(a, b, c, precision);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Factorial

    [Test, TestOf("Factorial")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Factorial))]
    public void Factorial<T>(T expected, T first) where T : struct, INumber<T>
    {
        if (first >= T.Zero)
        {
            var actual = first.Factorial();
            Assert.That(actual, Is.EqualTo(expected));
        }
        else
            Assert.Throws<ArgumentOutOfRangeException>(() => first.Factorial());
    }

    #endregion

    #region NumberOfCombinations

    [Test, TestOf("NumberOfCombinations")]
    [TestCaseSource(typeof(TestData), nameof(TestData.NumberOfCombinations))]
    public void NumberOfCombinations<T>(T expected, T numberOfItemsInSet, T sizeOfCombinations)
        where T : struct, INumber<T>
    {
        if (numberOfItemsInSet.IsLessThan(sizeOfCombinations))
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                MathUtils.NumberOfCombinations(numberOfItemsInSet, sizeOfCombinations));
        else
        {
            var actual = MathUtils.NumberOfCombinations(numberOfItemsInSet, sizeOfCombinations);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    #endregion

    # region Time

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MillSecToSec))]
    public void MillSecToSec<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.MillSecToSec(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MillSecToMin))]
    public void MillSecToMin<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.MillSecToMin(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MillSecToHour))]
    public void MillSecToHour<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.MillSecToHour(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MillSecToDay))]
    public void MillSecToDay<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.MillSecToDay(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MillSecToWeek))]
    public void MillSecToWeek<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.MillSecToWeek(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.SecToMillSec))]
    public void SecToMillSec<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.SecToMillSec(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.SecToMin))]
    public void SecToMin<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.SecToMin(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.SecToHour))]
    public void SecToHour<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.SecToHour(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.SecToDay))]
    public void SecToDay<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.SecToDay(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.SecToWeek))]
    public void SecToWeek<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.SecToWeek(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MinToMillSec))]
    public void MinToMillSec<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.MinToMillSec(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MinToSec))]
    public void MinToSec<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.MinToSec(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MinToHour))]
    public void MinToHour<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.MinToHour(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MinToDay))]
    public void MinToDay<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.MinToDay(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MinToWeek))]
    public void MinToWeek<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.MinToWeek(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.HourToMillSec))]
    public void HourToMillSec<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.HourToMillSec(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.HourToSec))]
    public void HourToSec<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.HourToSec(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.HourToMin))]
    public void HourToMin<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.HourToMin(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.HourToDay))]
    public void HourToDay<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.HourToDay(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.HourToWeek))]
    public void HourToWeek<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils.HourToWeek(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region ManhattenDistance

    [Test, TestOf("ManhattanDistance")]
    [TestCaseSource(typeof(TestData), nameof(TestData.ManhattanDistance))]
    public void ManhattanDistance<T>(T expected, (T, T) first, (T, T) second) where T : struct, INumber<T>
    {
        var actual = MathUtils.ManhattanDistance(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsNegative

    [Test, TestOf("IsNegative")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsNegative))]
    public void IsNegative<T>(bool expected, T first) where T : struct, INumber<T>
    {
        var actual = first.IsNegative();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsPositive

    [Test, TestOf("IsPositive")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsPositive))]
    public void IsPositive<T>(bool expected, T first) where T : struct, INumber<T>
    {
        var actual = first.IsPositive();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Abs

    [Test, TestOf("Abs")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Abs))]
    public void Abs<T>(T expected, T first) where T : struct, INumber<T>
    {
        var actual = first.Abs();
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion
}