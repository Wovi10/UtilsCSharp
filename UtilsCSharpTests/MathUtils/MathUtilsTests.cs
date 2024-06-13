using System.Numerics;
using UtilsCSharp;

namespace UtilsCSharpTests.MathUtils;

public class MathUtilsTests
{
    [SetUp]
    public void Setup()
    {
    }

    
    
    #region Add

    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.AddCasesNumbers))]
    public void Add<T>(T expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Add(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.AddCasesEnumerable))]
    public void Add<T>(T expected, IEnumerable<T> numbers, T seed, T constant) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Add(numbers, seed, constant);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Subtract
    
    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.SubtractCasesNumbers))]
    public void Subtract<T>(T expected, T first, T second, int? precision = null) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Sub(first, second, precision);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Multiply

    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.MultiplyCasesNumbers))]
    public void Multiply<T>(T expected, T first, T second, int? precision = null) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Mul(first, second, precision);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Divide

    [Test]
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

    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.GcdCases))]
    public void Gcd<T>(T expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Gcd(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Least Common Multiple
    
    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.LcmCases))]
    public void Lcm<T>(T expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Lcm(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region GetHighest

    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.GetHighest))]
    public void GetHighest<T>(T expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.GetHighest(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region GetLowest

    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.GetLowest))]
    public void GetLowest<T>(T expected, T first, T second) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.GetLowest(first, second);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsEven

    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsEven))]
    public void IsEven<T>(bool expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.IsEven(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsOdd

    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsOdd))]
    public void IsOdd<T>(bool expected, T first) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.IsOdd(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region IsPrime

    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.IsPrime))]
    public void IsPrime<T>(bool expected, T first) where T : struct, INumber<T>
    {
        var actual = MathUtils<T>.IsPrime(first);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Pythagorean Theorem

    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.PythagoreanTheorem))]
    public void PythagoreanTheorem<T>(T expected, T first, T second, int? precision = null) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.PythagoreanTheorem(first, second, precision);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Discriminant

    [Test]
    [TestCaseSource(typeof(TestData), nameof(TestData.Discriminant))]
    public void Discriminant<T>(T expected, T a, T b, T c, int? precision = null) where T: struct, INumber<T>
    {
        var actual = MathUtils<T>.Discriminant(a, b, c, precision);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Factorial

    [Test]
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

    [Test]
    public void IsGreaterThan_Integers_True()
    {
        var highest = 5;
        var lowest = 3;
        var actual = MathUtils<int>.IsGreaterThan(highest, lowest);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsGreaterThan_Integers_Null()
    {
        var both = 5;
        var actual = MathUtils<int>.IsGreaterThan(both, both);
        Assert.That(actual, Is.Null);
    }

    [Test]
    public void IsGreaterThan_Integers_False()
    {
        var lowest = 3;
        var highest = 5;
        var actual = MathUtils<int>.IsGreaterThan(lowest, highest);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsGreaterThan_Longs_True()
    {
        var highest = 5L;
        var lowest = 3L;
        var actual = MathUtils<long>.IsGreaterThan(highest, lowest);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsGreaterThan_Longs_Null()
    {
        var both = 5L;
        var actual = MathUtils<long>.IsGreaterThan(both, both);
        Assert.That(actual, Is.Null);
    }

    [Test]
    public void IsGreaterThan_Longs_False()
    {
        var lowest = 3L;
        var highest = 5L;
        var actual = MathUtils<long>.IsGreaterThan(lowest, highest);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsGreaterThan_Doubles_True()
    {
        var firstValue = 5.0;
        var actual = firstValue.IsGreaterThan(3.0);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsGreaterThan_Doubles_Null()
    {
        var firstValue = 5.0;
        var actual = firstValue.IsGreaterThan(5.0);
        Assert.That(actual, Is.Null);
    }

    [Test]
    public void IsGreaterThan_Doubles_False()
    {
        var firstValue = 3.0;
        var actual = firstValue.IsGreaterThan(5.0);
        Assert.That(actual, Is.False);
    }

    #endregion
/*
    #region IsLessThan

    [Test]
    public void IsLessThan_Integers_True()
    {
        var actual = 3.IsLessThan(5);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsLessThan_Integers_Null()
    {
        var actual = 5.IsLessThan(5);
        Assert.That(actual, Is.Null);
    }

    [Test]
    public void IsLessThan_Integers_False()
    {
        var actual = 5.IsLessThan(3);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsLessThan_Longs_True()
    {
        var firstValue = 3L;
        var actual = firstValue.IsLessThan(5L);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsLessThan_Longs_Null()
    {
        var firstValue = 5L;
        var actual = firstValue.IsLessThan(5L);
        Assert.That(actual, Is.Null);
    }

    [Test]
    public void IsLessThan_Longs_False()
    {
        var firstValue = 5L;
        var actual = firstValue.IsLessThan(3L);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsLessThan_Doubles_True()
    {
        var firstValue = 3.0;
        var actual = firstValue.IsLessThan(5.0);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsLessThan_Doubles_Null()
    {
        var firstValue = 5.0;
        var actual = firstValue.IsLessThan(5.0);
        Assert.That(actual, Is.Null);
    }

    [Test]
    public void IsLessThan_Doubles_False()
    {
        var firstValue = 5.0;
        var actual = firstValue.IsLessThan(3.0);
        Assert.That(actual, Is.False);
    }

    #endregion

    #region NumberOfCombinations

    [Test]
    public void NumberOfCombinations_Integers()
    {
        var actual = MathUtils.NumberOfCombinations(9, 2);
        const long expected = 36;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void NumberOfCombinations_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => MathUtils.NumberOfCombinations(9, 10));
    }

    #endregion

    # region Time

    [Test]
    public void MillSecToSec()
    {
        var actual = MathUtils.MillSecToSec(1000);
        const int expected = 1;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void MillSecToMin()
    {
        var actual = MathUtils.MillSecToMin(60000);
        const int expected = 1;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void MillSecToHour()
    {
        var actual = MathUtils.MillSecToHour(3600000);
        const int expected = 1;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void MillSecToDay()
    {
        var actual = MathUtils.MillSecToDay(86400000);
        const int expected = 1;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void MillSecToWeek()
    {
        var actual = MathUtils.MillSecToWeek(604800000);
        const int expected = 1;
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    # region IsBetween

    [Test]
    public void IsBetween_FullInclusive_True()
    {
        var valueToTest = 5;
        var actual = valueToTest.IsBetween(3, 7);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsBetween_FullInclusive_False()
    {
        var valueToTest = 2;
        var actual = valueToTest.IsBetween(3, 7);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsBetween_FullInclusive_LowerEqual()
    {
        var valueToTest = 3;
        var actual = valueToTest.IsBetween(3, 7);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsBetween_FullInclusive_UpperEqual()
    {
        var valueToTest = 7;
        var actual = valueToTest.IsBetween(3, 7);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsBetween_FullInclusive_LowerEqualUpperEqual()
    {
        var valueToTest = 3;
        var actual = valueToTest.IsBetween(3, 3);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsBetween_LowerInclusive_True()
    {
        var valueToTest = 5;
        var actual = valueToTest.IsBetween(3, 7, true, false);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsBetween_LowerInclusive_False()
    {
        var valueToTest = 2;
        var actual = valueToTest.IsBetween(3, 7, true, false);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsBetween_LowerInclusive_LowerEqual()
    {
        var valueToTest = 3;
        var actual = valueToTest.IsBetween(3, 7, true, false);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsBetween_LowerInclusive_UpperEqual()
    {
        var valueToTest = 7;
        var actual = valueToTest.IsBetween(3, 7, true, false);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsBetween_LowerInclusive_LowerEqualUpperEqual_False()
    {
        var valueToTest = 3;
        var actual = valueToTest.IsBetween(3, 3, true, false);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsBetween_UpperInclusive_True()
    {
        var valueToTest = 5;
        var actual = valueToTest.IsBetween(3, 7, false, true);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsBetween_UpperInclusive_False()
    {
        var valueToTest = 2;
        var actual = valueToTest.IsBetween(3, 7, false, true);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsBetween_UpperInclusive_LowerEqual()
    {
        var valueToTest = 3;
        var actual = valueToTest.IsBetween(3, 7, false, true);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsBetween_UpperInclusive_UpperEqual()
    {
        var valueToTest = 7;
        var actual = valueToTest.IsBetween(3, 7, false, true);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsBetween_UpperInclusive_LowerEqualUpperEqual_False()
    {
        var valueToTest = 3;
        var actual = valueToTest.IsBetween(3, 3, false, true);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsBetween_Exclusive_True()
    {
        var valueToTest = 5;
        var actual = valueToTest.IsBetween(3, 7, false, false);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsBetween_Exclusive_False()
    {
        var valueToTest = 2;
        var actual = valueToTest.IsBetween(3, 7, false, false);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsBetween_Exclusive_LowerEqual()
    {
        var valueToTest = 3;
        var actual = valueToTest.IsBetween(3, 7, false, false);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsBetween_Exclusive_UpperEqual()
    {
        var valueToTest = 7;
        var actual = valueToTest.IsBetween(3, 7, false, false);
        Assert.That(actual, Is.False);
    }

    # endregion

    [Test]
    public void IsGreaterThanOrEqualTo_true()
    {
        var valueToTest = 5;
        var actual = valueToTest.IsGreaterThanOrEqualTo(5);
        Assert.That(actual, Is.True);
    }
    
    [Test]
    public void IsGreaterThanOrEqualTo_false()
    {
        var valueToTest = 5;
        var actual = valueToTest.IsGreaterThanOrEqualTo(6);
        Assert.That(actual, Is.False);
    }
    
    [Test]
    public void IsLessThanOrEqualTo_true()
    {
        var valueToTest = 5;
        var actual = valueToTest.IsLessThanOrEqualTo(5);
        Assert.That(actual, Is.True);
    }
    
    [Test]
    public void IsLessThanOrEqualTo_false()
    {
        var valueToTest = 5;
        var actual = valueToTest.IsLessThanOrEqualTo(4);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void ManhattanDistance()
    {
        var actual = MathUtils.ManhattanDistance((0, 0), (3, 4));
        const int expected = 7;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void IsNegative_negativeNumber()
    {
        var input = -5;
        var actual = input.IsNegative();
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsNegative_positiveNumber()
    {
        var input = 5;
        var actual = input.IsNegative();
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsNegative_zero()
    {
        var input = 0;
        var actual = input.IsNegative();
        Assert.That(actual, Is.False);
    }

    [Test]
    public void Abs_NegativeNumber()
    {
        var input = -5;
        var actual = MathUtils.Abs(input);
        const int expected = 5;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Abs_PositiveNumber()
    {
        var input = 5;
        var actual = MathUtils.Abs(input);
        const int expected = 5;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Abs_Zero()
    {
        var input = 0;
        var actual = MathUtils.Abs(input);
        const int expected = 0;
        Assert.That(actual, Is.EqualTo(expected));
    }


*/
}