using System.Numerics;
using UtilsCSharp;

namespace UtilsCSharpTests.MathUtils;

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
    public void Add<T>(T expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Add(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test, TestOf("Add")]
    [TestCaseSource(typeof(TestData), nameof(TestData.AddCasesEnumerable))]
    public void Add<T>(T expected, IEnumerable<T> numbers, T seed, T constant) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Add(numbers, seed, constant);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Subtract
    
    [Test, TestOf("Subtract")]
    [TestCaseSource(typeof(TestData), nameof(TestData.SubtractCasesNumbers))]
    public void Subtract<T>(T expected, T first, T second, int? precision = null) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Sub(first, second, precision);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Multiply

    [Test, TestOf("Multiply")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MultiplyCasesNumbers))]
    public void Multiply<T>(T expected, T first, T second, int? precision = null) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Mul(first, second, precision);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Divide

    [Test, TestOf("Divide")]
    [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesNumbers))]
    public void Divide<T>(T expected, T first, T second, int? precision = null) where T: struct, INumber<T>
    {
        if (second != T.Zero)
        {
            var actual = MathUtils<T>.Div(first, second, precision);
            Assert.That(actual, Is.EqualTo(expected));
        }
        else
            Assert.Throws<DivideByZeroException>(() => MathUtils<T>.Div(first, second, precision));
    }

    #endregion

    #region Greatest Common Dividor

    [Test, TestOf("GCD")]
    [TestCaseSource(typeof(TestData), nameof(TestData.GcdCases))]
    public void Gcd<T>(T expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Gcd(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Least Common Multiple
    
    [Test, TestOf("LCM")]
    [TestCaseSource(typeof(TestData), nameof(TestData.LcmCases))]
    public void Lcm<T>(T expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Lcm(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region GetHighest

    [Test, TestOf("GetHighest")]
    [TestCaseSource(typeof(TestData), nameof(TestData.GetHighest))]
    public void GetHighest<T>(T expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.GetHighest(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region GetLowest

    [Test, TestOf("GetLowest")]
    [TestCaseSource(typeof(TestData), nameof(TestData.GetLowest))]
    public void GetLowest<T>(T expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.GetLowest(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsEven

    [Test, TestOf("IsEven")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsEven))]
    public void IsEven<T>(bool expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.IsEven(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsOdd

    [Test, TestOf("IsOdd")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsOdd))]
    public void IsOdd<T>(bool expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.IsOdd(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsPrime

    [Test, TestOf("IsPrime")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsPrime))]
    public void IsPrime<T>(bool expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils<T>.IsPrime(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Pythagorean Theorem

    [Test, TestOf("Pythagorean Theorem")]
    [TestCaseSource(typeof(TestData), nameof(TestData.PythagoreanTheorem))]
    public void PythagoreanTheorem<T>(T expected, T first, T second, int? precision = null) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.PythagoreanTheorem(first, second, precision);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Discriminant

    [Test, TestOf("Discriminant")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Discriminant))]
    public void Discriminant<T>(T expected, T a, T b, T c, int? precision = null) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Discriminant(a, b, c, precision);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Factorial

    [Test, TestOf("Factorial")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Factorial))]
    public void Factorial<T>(T expected, T first) where T: struct, INumber<T>
    {
        if (first >= T.Zero)
        {
            var actual = MathUtils<T>.Factorial(first);
            Assert.That(actual, Is.EqualTo(expected));
        }
        else
            Assert.Throws<ArgumentOutOfRangeException>(() => MathUtils<T>.Factorial(first));
    }

    #endregion

    #region IsGreaterThan
    
    [Test, TestOf("IsGreaterThan")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsGreaterThan))]
    public void IsGreaterThan<T>(bool? expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.IsGreaterThan(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsGreaterThan))]
    public void IsBiggerThan<T>(bool? expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.IsBiggerThan(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsLessThan

    [Test, TestOf("IsLessThan")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsSmallerThan))]
    public void IsLessThan<T>(bool? expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.IsLessThan(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region NumberOfCombinations

    [Test, TestOf("NumberOfCombinations")]
    [TestCaseSource(typeof(TestData), nameof(TestData.NumberOfCombinations))]
    public void NumberOfCombinations<T>(T expected, T numberOfItemsInSet, T sizeOfCombinations) where T: struct, INumber<T>
    {
        if (MathUtils<T>.IsLessThan(numberOfItemsInSet, sizeOfCombinations) == true)
            Assert.Throws<ArgumentOutOfRangeException>(() => MathUtils<T>.NumberOfCombinations(numberOfItemsInSet, sizeOfCombinations));
        else
        {
            var actual = MathUtils<T>.NumberOfCombinations(numberOfItemsInSet, sizeOfCombinations);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    #endregion

    # region Time
    
    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MillSecToSec))]
    public void MillSecToSec<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.MillSecToSec(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MillSecToMin))]
    public void MillSecToMin<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.MillSecToMin(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MillSecToHour))]
    public void MillSecToHour<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.MillSecToHour(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MillSecToDay))]
    public void MillSecToDay<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.MillSecToDay(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MillSecToWeek))]
    public void MillSecToWeek<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.MillSecToWeek(first);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.SecToMillSec))]
    public void SecToMillSec<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.SecToMillSec(first);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.SecToMin))]
    public void SecToMin<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.SecToMin(first);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.SecToHour))]
    public void SecToHour<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.SecToHour(first);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.SecToDay))]
    public void SecToDay<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.SecToDay(first);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.SecToWeek))]
    public void SecToWeek<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.SecToWeek(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MinToMillSec))]
    public void MinToMillSec<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.MinToMillSec(first);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MinToSec))]
    public void MinToSec<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.MinToSec(first);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MinToHour))]
    public void MinToHour<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.MinToHour(first);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MinToDay))]
    public void MinToDay<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.MinToDay(first);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MinToWeek))]
    public void MinToWeek<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.MinToWeek(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.HourToMillSec))]
    public void HourToMillSec<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.HourToMillSec(first);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.HourToSec))]
    public void HourToSec<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.HourToSec(first);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.HourToMin))]
    public void HourToMin<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.HourToMin(first);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.HourToDay))]
    public void HourToDay<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.HourToDay(first);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test, TestOf("Time")]
    [TestCaseSource(typeof(TestData), nameof(TestData.HourToWeek))]
    public void HourToWeek<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.HourToWeek(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion
    
    # region IsBetween

    [Test, TestOf("IsBetween")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsBetween))]
    public void IsBetween<T>(bool expected, T first, T lower, T upper, bool lowerInclusive, bool upperInclusive) where 
        T: struct, INumber<T>
    {
        var actual = MathUtils<T>.IsBetween(first, lower, upper, lowerInclusive, upperInclusive);
        Assert.That(actual, Is.EqualTo(expected));
    }

    # endregion

    #region IsGreaterThanOrEqualTo

    [Test, TestOf("IsGreaterThanOrEqualTo")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsGreaterThanOrEqualTo))]
    public void IsGreaterThanOrEqualTo<T>(bool expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.IsGreaterThanOrEqualTo(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsLessThanOrEqualTo
    
    [Test, TestOf("IsLessThanOrEqualTo")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsLessThanOrEqualTo))]
    public void IsLessThanOrEqualTo<T>(bool expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.IsLessThanOrEqualTo(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region ManhattenDistance
    
    [Test, TestOf("ManhattanDistance")]
    [TestCaseSource(typeof(TestData), nameof(TestData.ManhattanDistance))]
    public void ManhattanDistance<T>(T expected, (T, T) first, (T, T) second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.ManhattanDistance(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsNegative
    
    [Test, TestOf("IsNegative")]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsNegative))]
    public void IsNegative<T>(bool expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.IsNegative(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Abs
    
    [Test, TestOf("Abs")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Abs))]
    public void Abs<T>(T expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Abs(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion
}