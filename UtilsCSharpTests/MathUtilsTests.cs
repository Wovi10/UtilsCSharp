using UtilsCSharp;

namespace UtilsCSharpTests;

public class MathUtilsTests
{
    [SetUp]
    public void Setup()
    {
    }

    #region Add

    [Test]
    public void Add_Integers()
    {
        var actual = MathUtils.Add(3, 2);
        const int expected = 5;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Longs()
    {
        var actual = MathUtils.Add(3L, 2L);
        const long expected = 5L;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Doubles()
    {
        var actual = MathUtils.Add(3.21, 2.34);
        const double expected = 5.55;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Strings()
    {
        var actual = MathUtils.Add("Something", "Else");
        const string expected = "SomethingElse";
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Enumerable_Int()
    {
        var actual = MathUtils.Add(new List<int> {1, 2, 3, 4});
        const int expected = 10;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Enumerable_Int_Seed()
    {
        var actual = MathUtils.Add(new List<int> {1, 2, 3, 4}, 5);
        const int expected = 15;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Enumerable_Int_Seed_Constant()
    {
        var actual = MathUtils.Add(new List<int> {1, 2, 3, 4}, 5, 6);
        const int expected = 39;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Enumerable_Long()
    {
        var actual = MathUtils.Add(new List<long> {1, 2, 3, 4});
        const long expected = 10;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Enumerable_Long_Seed()
    {
        var actual = MathUtils.Add(new List<long> {1, 2, 3, 4}, 5);
        const long expected = 15;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Enumerable_Long_Seed_Constant()
    {
        var actual = MathUtils.Add(new List<long> {1, 2, 3, 4}, 5, 6);
        const long expected = 39;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Enumerable_Double()
    {
        var actual = MathUtils.Add(new List<double> {1, 2, 3, 4});
        const double expected = 10;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Enumerable_Double_Seed()
    {
        var actual = MathUtils.Add(new List<double> {1, 2, 3, 4}, 5);
        const double expected = 15;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Enumerable_Double_Seed_Constant()
    {
        var actual = MathUtils.Add(new List<double> {1, 2, 3, 4}, 5, 6);
        const double expected = 39;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Enumerable_String()
    {
        var actual = MathUtils.Add(new List<string> {"1", "2", "3", "4"});
        const string expected = "1234";
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Enumerable_String_Seed()
    {
        var actual = MathUtils.Add(new List<string> {"1", "2", "3", "4"}, "5");
        const string expected = "51234";
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Add_Enumerable_String_Seed_Constant()
    {
        var actual = MathUtils.Add(new List<string> {"1", "2", "3", "4"}, "5", "6");
        const string expected = "516263646";
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Subtract

    [Test]
    public void Subtract_Integers()
    {
        var actual = MathUtils.Sub(3, 2);
        const int expected = 1;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Subtract_Longs()
    {
        var actual = MathUtils.Sub(3L, 2L);
        const long expected = 1L;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Subtract_Doubles()
    {
        var actual = MathUtils.Sub(3.21, 2.34, 2);
        const double expected = 0.87;
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Multiply

    [Test]
    public void Multiply_Integers()
    {
        var actual = MathUtils.Mul(3, 2);
        const int expected = 6;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Multiply_Longs()
    {
        var actual = MathUtils.Mul(3L, 2L);
        const long expected = 6L;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Multiply_DoubleWithPrecision()
    {
        var actual = MathUtils.Mul(3.21, 2.345, 3);
        const double expected = 7.527;
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Divide

    [Test]
    public void Divide_Integers()
    {
        var actual = MathUtils.Div(3, 2);
        const double expected = 1.5;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Divide_IntegersZero_Throws()
    {
        Assert.Throws<DivideByZeroException>(() => MathUtils.Div(3, 0));
    }

    [Test]
    public void Divide_Longs()
    {
        var actual = MathUtils.Div(3L, 2L);
        const double expected = 1.5;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Divide_LongsZero_Throws()
    {
        Assert.Throws<DivideByZeroException>(() => MathUtils.Div(3L, 0L));
    }

    [Test]
    public void Divide_Doubles()
    {
        var actual = MathUtils.Div(3.21, 2.34, 2);
        const double expected = 1.37;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Divide_DoublesZero_Throws()
    {
        Assert.Throws<DivideByZeroException>(() => MathUtils.Div(3.21, 0.0));
    }

    #endregion

    #region Greatest Common Dividor

    [Test]
    public void Gcd_Integers()
    {
        var actual = MathUtils.Gcd(12, 9);
        const int expected = 3;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Gcd_Integers_Zero()
    {
        var actual = MathUtils.Gcd(0, 0);
        const int expected = 1;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Gcd_Longs()
    {
        var actual = MathUtils.Gcd(12L, 9L);
        const long expected = 3L;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Gcd_Longs_Zero()
    {
        var actual = MathUtils.Gcd(0L, 0L);
        const long expected = 1L;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Gcd_Doubles()
    {
        var actual = MathUtils.Gcd(12.0, 9.0);
        const double expected = 3.0;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Gcd_Doubles_Zero()
    {
        var actual = MathUtils.Gcd(0.0, 0.0);
        const double expected = 1.0;
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Least Common Multiple

    [Test]
    public void Lcm_Integers()
    {
        var actual = MathUtils.Lcm(12, 9);
        const int expected = 36;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Lcm_Longs()
    {
        var actual = MathUtils.Lcm(12L, 9L);
        const long expected = 36L;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Lcm_Doubles()
    {
        var actual = MathUtils.Lcm(12.0, 9.0);
        const double expected = 36.0;
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region GetHighest

    [Test]
    public void GetHighest_IntegersHighFirst()
    {
        const int highest = 12;
        const int lowest = 9;
        var actual = MathUtils.GetHighest(highest, lowest);
        Assert.That(actual, Is.EqualTo(highest));
    }

    [Test]
    public void GetHighest_IntegersLowFirst()
    {
        const int highest = 12;
        const int lowest = 9;
        var actual = MathUtils.GetHighest(lowest, highest);
        Assert.That(actual, Is.EqualTo(highest));
    }

    [Test]
    public void GetHighest_IntegersEqual()
    {
        const int both = 12;
        var actual = MathUtils.GetHighest(both, both);
        Assert.That(actual, Is.EqualTo(both));
    }

    [Test]
    public void GetHighest_LongsHighFirst()
    {
        const long highest = 12L;
        const long lowest = 9L;
        var actual = MathUtils.GetHighest(highest, lowest);
        Assert.That(actual, Is.EqualTo(highest));
    }

    [Test]
    public void GetHighest_LongsLowFirst()
    {
        const long highest = 12L;
        const long lowest = 9L;
        var actual = MathUtils.GetHighest(lowest, highest);
        Assert.That(actual, Is.EqualTo(highest));
    }

    [Test]
    public void GetHighest_LongsEqual()
    {
        const long both = 12L;
        var actual = MathUtils.GetHighest(both, both);
        Assert.That(actual, Is.EqualTo(both));
    }

    [Test]
    public void GetHighest_DoublesHighFirst()
    {
        const double highest = 12.0;
        const double lowest = 9.0;
        var actual = MathUtils.GetHighest(highest, lowest);
        Assert.That(actual, Is.EqualTo(highest));
    }

    [Test]
    public void GetHighest_DoublesLowFirst()
    {
        const double highest = 12.0;
        const double lowest = 9.0;
        var actual = MathUtils.GetHighest(lowest, highest);
        Assert.That(actual, Is.EqualTo(highest));
    }

    [Test]
    public void GetHighest_DoublesEqual()
    {
        const double both = 12.0;
        var actual = MathUtils.GetHighest(both, both);
        Assert.That(actual, Is.EqualTo(both));
    }

    #endregion

    #region GetLowest

    [Test]
    public void GetLowest_IntegersHighFirst()
    {
        const int highest = 12;
        const int lowest = 9;
        var actual = MathUtils.GetLowest(highest, lowest);
        Assert.That(actual, Is.EqualTo(lowest));
    }

    [Test]
    public void GetLowest_IntegersLowFirst()
    {
        const int highest = 12;
        const int lowest = 9;
        var actual = MathUtils.GetLowest(lowest, highest);
        Assert.That(actual, Is.EqualTo(lowest));
    }

    [Test]
    public void GetLowest_IntegersEqual()
    {
        const int both = 12;
        var actual = MathUtils.GetLowest(both, both);
        Assert.That(actual, Is.EqualTo(both));
    }

    [Test]
    public void GetLowest_LongsHighFirst()
    {
        const long highest = 12L;
        const long lowest = 9L;
        var actual = MathUtils.GetLowest(highest, lowest);
        Assert.That(actual, Is.EqualTo(lowest));
    }

    [Test]
    public void GetLowest_LongsLowFirst()
    {
        const long highest = 12L;
        const long lowest = 9L;
        var actual = MathUtils.GetLowest(lowest, highest);
        Assert.That(actual, Is.EqualTo(lowest));
    }

    [Test]
    public void GetLowest_LongsEqual()
    {
        const long both = 12L;
        var actual = MathUtils.GetLowest(both, both);
        Assert.That(actual, Is.EqualTo(both));
    }

    [Test]
    public void GetLowest_DoublesHighFirst()
    {
        const double highest = 12.235;
        const double lowest = 12.234;
        var actual = MathUtils.GetLowest(highest, lowest);
        Assert.That(actual, Is.EqualTo(lowest));
    }

    [Test]
    public void GetLowest_DoublesLowFirst()
    {
        const double highest = 12.0;
        const double lowest = 9.0;
        var actual = MathUtils.GetLowest(lowest, highest);
        Assert.That(actual, Is.EqualTo(lowest));
    }

    [Test]
    public void GetLowest_DoublesEqual()
    {
        const double both = 12.0;
        var actual = MathUtils.GetLowest(both, both);
        Assert.That(actual, Is.EqualTo(both));
    }

    #endregion

    #region IsEven

    [Test]
    public void IsEven_IntegersEven()
    {
        var actual = 12.IsEven();
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsEven_IntegersOdd()
    {
        var actual = 9.IsEven();
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsEven_LongsEven()
    {
        var valueToTest = 12L;
        var actual = valueToTest.IsEven();
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsEven_LongsOdd()
    {
        var valueToTest = 9L;
        var actual = valueToTest.IsEven();
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsEven_DoublesEven()
    {
        var valueToTest = 12.0;
        var actual = valueToTest.IsEven();
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsEven_DoublesOdd()
    {
        var valueToTest = 9.0;
        var actual = valueToTest.IsEven();
        Assert.That(actual, Is.False);
    }

    #endregion

    #region IsOdd

    [Test]
    public void IsOdd_IntegersEven()
    {
        var actual = 12.IsOdd();
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsOdd_IntegersOdd()
    {
        var actual = 9.IsOdd();
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsOdd_LongsEven()
    {
        var valueToTest = 12L;
        var actual = valueToTest.IsOdd();
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsOdd_LongsOdd()
    {
        var valueToTest = 9L;
        var actual = valueToTest.IsOdd();
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsOdd_DoublesEven()
    {
        var valueToTest = 12.0;
        var actual = valueToTest.IsOdd();
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsOdd_DoublesOdd()
    {
        var valueToTest = 9.0;
        var actual = valueToTest.IsOdd();
        Assert.That(actual, Is.True);
    }

    #endregion

    #region IsPrime

    [Test]
    public void IsPrime_Integers_True()
    {
        var actual = 7.IsPrime();
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsPrime_Integers_False()
    {
        var actual = 9.IsPrime();
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsPrime_Longs_True()
    {
        var valueToTest = 7L;
        var actual = valueToTest.IsPrime();
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsPrime_Longs_False()
    {
        var valueToTest = 9L;
        var actual = valueToTest.IsPrime();
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsPrime_Doubles_True()
    {
        var valueToTest = 7.0;
        var actual = valueToTest.IsPrime();
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsPrime_Doubles_False()
    {
        var valueToTest = 9.0;
        var actual = valueToTest.IsPrime();
        Assert.That(actual, Is.False);
    }

    #endregion

    #region Pythagorean Theorem

    [Test]
    public void PythagoreanTheorem_Integers345()
    {
        var actual = MathUtils.PythagoreanTheorem(3, 4);
        const double expected = 5;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void PythagoreanTheorem_Longs345()
    {
        var actual = MathUtils.PythagoreanTheorem(4L, 3L);
        const double expected = 5L;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void PythagoreanTheorem_Doubles345()
    {
        var actual = MathUtils.PythagoreanTheorem(4.0, 3.0);
        const double expected = 5.0;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void PythagoreanTheorem_Doubles345WithPrecision()
    {
        var actual = MathUtils.PythagoreanTheorem(4.2, 3.1, 4);
        const double expected = 5.2202;
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Discriminant

    [Test]
    public void Discriminant_Integers()
    {
        var actual = MathUtils.Discriminant(2, 3, 4);
        const double expected = -23;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Discriminant_Longs()
    {
        var actual = MathUtils.Discriminant(2L, 3L, 4L);
        const double expected = -23L;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Discriminant_Doubles()
    {
        var actual = MathUtils.Discriminant(2.0, 3.0, 4.0, 2);
        const double expected = -23.00;
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion

    #region Factorial

    [Test]
    public void Factorial_Integers()
    {
        var actual = MathUtils.Factorial(5);
        const long expected = 120;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Factorial_IntegersZero()
    {
        var actual = MathUtils.Factorial(0);
        const long expected = 1;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Factorial_IntegersNegative_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => MathUtils.Factorial(-5));
    }

    [Test]
    public void Factorial_Longs()
    {
        var actual = MathUtils.Factorial(5L);
        const long expected = 120L;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Factorial_LongsZero()
    {
        var actual = MathUtils.Factorial(0L);
        const long expected = 1L;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Factorial_LongsNegative_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => MathUtils.Factorial(-5L));
    }

    [Test]
    public void Factorial_Doubles()
    {
        var actual = MathUtils.Factorial(5.0);
        const double expected = 120.0;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Factorial_DoublesZero()
    {
        var actual = MathUtils.Factorial(0.0);
        const double expected = 1.0;
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Factorial_DoublesNegative_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => MathUtils.Factorial(-5.0));
    }

    #endregion

    #region IsGreaterThan

    [Test]
    public void IsGreaterThan_Integers_True()
    {
        var actual = 5.IsGreaterThan(3);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsGreaterThan_Integers_Null()
    {
        var actual = 5.IsGreaterThan(5);
        Assert.That(actual, Is.Null);
    }

    [Test]
    public void IsGreaterThan_Integers_False()
    {
        var actual = 3.IsGreaterThan(5);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void IsGreaterThan_Longs_True()
    {
        var firstValue = 5L;
        var actual = firstValue.IsGreaterThan(3L);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void IsGreaterThan_Longs_Null()
    {
        var firstValue = 5L;
        var actual = firstValue.IsGreaterThan(5L);
        Assert.That(actual, Is.Null);
    }

    [Test]
    public void IsGreaterThan_Longs_False()
    {
        var firstValue = 3L;
        var actual = firstValue.IsGreaterThan(5L);
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
}