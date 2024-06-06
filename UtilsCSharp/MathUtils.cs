using System.Numerics;

namespace UtilsCSharp;

public static class MathUtils
{
    #region Add

    /// <summary>
    /// Generic implementation of the Add function.
    /// </summary>
    /// <param name="a">parameter 1</param>
    /// <param name="b">parameter 2</param>
    /// <typeparam name="TSelf">The type you want to use</typeparam>
    /// <returns></returns>
    public static TSelf Add<TSelf>(TSelf a, TSelf b) where TSelf : INumber<TSelf>
        => a + b;

    public static string Add(string a, string b)
        => a + b;

    /// <summary>
    /// This will add every number in the enumerable to the seed.
    /// </summary>
    /// <param name="a">IEnumerable of int</param>
    /// <param name="seed">The initial value.</param>
    /// <param name="constant">If given, this constant will be added everytime two entries are added.</param>
    /// <returns>The sum of the seed and all entries of the collection</returns>
    public static int Add(IEnumerable<int> a, int seed = 0, int constant = 0)
    {
        if (constant == 0 && seed == 0)
            return Add(a);

        if (constant == 0)
            return a.Aggregate(seed, Add);

        if (seed == 0)
            return a.Aggregate((a, b) => Add(Add(a, b), constant));

        return a.Aggregate(seed, (a, b) => Add(Add(a, b), constant));
    }

    private static int Add(IEnumerable<int> a)
        => a.Aggregate(Add);

    /// <summary>
    /// This will add every number in the enumerable to the seed.
    /// </summary>
    /// <param name="a">IEnumerable of long</param>
    /// <param name="seed">The initial value.</param>
    /// <param name="constant">If given, this constant will be added everytime two entries are added.</param>
    /// <returns>The sum of the seed and all entries of the collection</returns>
    public static long Add(IEnumerable<long> a, long seed = 0, long constant = 0)
    {
        if (constant == 0 && seed == 0)
            return Add(a);

        if (constant == 0)
            return a.Aggregate(seed, Add);

        if (seed == 0)
            return a.Aggregate((a, b) => Add(Add(a, b), constant));

        return a.Aggregate(seed, (a, b) => Add(Add(a, b), constant));
    }

    private static long Add(IEnumerable<long> a)
        => a.Aggregate(Add);

    /// <summary>
    /// This will add every number in the enumerable to the seed.
    /// </summary>
    /// <param name="a">IEnumerable of long</param>
    /// <param name="seed">The initial value.</param>
    /// <param name="constant">If given, this constant will be added everytime two entries are added.</param>
    /// <returns>The sum of the seed and all entries of the collection</returns>
    public static double Add(IEnumerable<double> a, double seed = 0.0, double constant = 0.0)
    {
        if (constant == 0.0 && seed == 0.0)
            return Add(a);

        if (constant == 0.0)
            return a.Aggregate(seed, Add);

        if (seed == 0.0)
            return a.Aggregate((a, b) => Add(Add(a, b), constant));

        return a.Aggregate(seed, (a, b) => Add(Add(a, b), constant));
    }

    private static double Add(IEnumerable<double> a)
        => a.Aggregate(Add);

    /// <summary>
    /// This will add every number in the enumerable to the seed.
    /// </summary>
    /// <param name="a">IEnumerable of long</param>
    /// <param name="seed">The initial value.</param>
    /// <param name="constant">If given, this constant will be added everytime two entries are added.</param>
    /// <returns>The concatenation of the seed and all entries of the collection.</returns>
    public static string Add(IEnumerable<string> a, string seed = "", string constant = "")
    {
        if (constant == "" && seed == "")
            return Add(a);

        if (constant == "")
            return a.Aggregate(seed, Add);

        if (seed == "")
            return a.Aggregate((a, b) => Add(Add(a, b), constant));

        return a.Aggregate(seed, (a, b) => Add(Add(a, b), constant));
    }

    private static string Add(IEnumerable<string> a)
        => a.Aggregate(Add);

    #endregion

    #region Subtract

    /// <summary>
    /// Generic implementation of the Subtract function.
    /// </summary>
    /// <param name="a">parameter 1</param>
    /// <param name="b">parameter 2</param>
    /// <typeparam name="TSelf">The type to be used.</typeparam>
    /// <returns></returns>
    public static TSelf Sub<TSelf>(TSelf a, TSelf b) where TSelf : INumber<TSelf>
        => a - b;

    /// <summary>
    /// Subtract to doubles.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="precision">Required precision of the output (ignored if left empty)</param>
    /// <returns></returns>
    public static double Sub(double a, double b, int? precision = null)
    {
        if (precision == null)
            return a - b;
        return Math.Round(a - b, precision.Value);
    }

    #endregion

    #region Multiply

    /// <summary>
    /// Generic implementation of the Multiply function.
    /// </summary>
    /// <param name="a">parameter 1</param>
    /// <param name="b">parameter 2</param>
    /// <typeparam name="TSelf">The type to be used.</typeparam>
    /// <returns></returns>
    public static TSelf Mul<TSelf>(TSelf a, TSelf b) where TSelf : INumber<TSelf>
        => a * b;

    /// <summary>
    /// Multiply two doubles.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="returnPrecision">The desired precision of the return value.</param>
    /// <returns></returns>
    public static double Mul(double a, double b, int returnPrecision)
    {
        return Math.Round(a * b, returnPrecision);
    }

    #endregion

    #region Divide

    /// <summary>
    /// Generic implementation of the Divide function.
    /// </summary>
    /// <param name="a">parameter 1</param>
    /// <param name="b">parameter 2</param>
    /// <typeparam name="TSelf">The type to be used.</typeparam>
    /// <returns></returns>
    public static TSelf Div<TSelf>(TSelf a, TSelf b) where TSelf : INumber<TSelf>
    {
        if (TSelf.IsZero(b))
            throw new DivideByZeroException();

        return a / b;
    }

    public static double Div(double a, double b, int? returnPrecision = null)
    {
        if (b == 0)
            throw new DivideByZeroException();
        return returnPrecision == null
            ? a / b
            : Math.Round(a / b, returnPrecision.Value);
    }

    #endregion

    #region Greatest Common Dividor

    /// <summary>
    /// Generic Greatest Common Dividor.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <typeparam name="TSelf">The type to be used.</typeparam>
    /// <returns></returns>
    public static TSelf Gcd<TSelf>(TSelf a, TSelf b) where TSelf : INumber<TSelf>
    {
        if (a == TSelf.Zero && b == TSelf.Zero)
            return TSelf.One;
        return b == TSelf.Zero
            ? a
            : Gcd(b, a % b);
    }

    #endregion

    #region Least Common Multiple

    /// <summary>
    /// Generic Least Common Multiple.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <typeparam name="TSelf"></typeparam>
    /// <returns></returns>
    public static TSelf Lcm<TSelf>(TSelf a, TSelf b) where TSelf : INumber<TSelf>
        => a * b / Gcd(a, b);

    #endregion

    #region GetHighest

    public static T GetHighest<T>(T a, T b) where T : INumber<T>
        => a.CompareTo(b) > 0 ? a : b;

    #endregion

    #region GetLowest

    public static T GetLowest<T>(T a, T b) where T : INumber<T>
        => a.CompareTo(b) < 0 ? a : b;

    #endregion

    #region IsEven

    public static bool IsEven<TSelf>(this TSelf a) where TSelf : INumber<TSelf> =>
        TSelf.IsEvenInteger(a);

    #endregion

    #region IsOdd

    public static bool IsOdd<T>(this T a) where T : INumber<T>
        => T.IsOddInteger(a);

    #endregion

    #region IsPrime

    public static bool IsPrime<T>(this T a) where T : INumber<T>
    {
        switch (a)
        {
            case <= 1:
                return false;
            case 2:
                return true;
        }

        if (a.IsEven())
            return false;

        for (var i = 3; i <= Math.Sqrt(double.CreateChecked(a)); i += 2)
            if (T.IsZero(a % T.CreateChecked(i)))
                return false;

        return true;
    }

    #endregion

    #region PythagoreanTheorem

    public static double PythagoreanTheorem<T>(T a, T b, int? returnPrecision = null) where T : INumber<T>
    {
        var squaredA = Math.Pow(double.CreateChecked(a), 2);
        var squaredB = Math.Pow(double.CreateChecked(b), 2);
        return 
            returnPrecision == null
                ? Math.Sqrt(squaredA + squaredB)
                : Math.Round(PythagoreanTheorem(a, b), returnPrecision.Value);
    }

    #endregion

    #region Discrimant

    public static double Discriminant<T>(T a, T b, T c, int? returnPrecision = null) where T : INumber<T>
    {
        return 
            returnPrecision == null
                ? Math.Pow(double.CreateChecked(b), 2) - 4 * double.CreateChecked(a) * double.CreateChecked(c)
                : Math.Round(Discriminant(a, b, c), returnPrecision.Value);
    }

    #endregion

    #region Factorial

    public static T Factorial<T>(T a) where T : INumber<T>
    {
        if (a.IsNegative())
            throw new ArgumentOutOfRangeException(nameof(a), "Factorial of a negative number is undefined.");

        if (T.IsZero(a))
            return T.One;

        return
            a.CompareTo(T.One) == 0
                ? T.One
                : Mul(a, Factorial(Sub(a, T.One)));
    }

    #endregion

    #region IsGreaterThan

    public static bool? IsGreaterThan<T>(this T a, T b) where T : INumber<T>
    {
        return a.CompareTo(b) switch
        {
            > 0 => true,
            < 0 => false,
            _ => null
        };
    }
    
    #endregion

    #region IsLessThan

    public static bool? IsLessThan<T>(this T a, T b) where T : INumber<T>
    {
        return a.CompareTo(b) switch
        {
            < 0 => true,
            > 0 => false,
            _ => null
        };
    }

    #endregion
    
    #region IsGreaterThanOrEqualTo
    
    public static bool IsGreaterThanOrEqualTo<T>(this T a, T b) where T : INumber<T>
    {
        return a.CompareTo(b) switch
        {
            > 0 => true,
            < 0 => false,
            _ => true
        };
    }
    
    #endregion
    
    #region IsLessThanOrEqualTo
    
    public static bool IsLessThanOrEqualTo<T>(this T a, T b) where T : INumber<T>
    {
        return a.CompareTo(b) switch
        {
            < 0 => true,
            > 0 => false,
            _ => true
        };
    }
    
    #endregion

    #region NumberOfCombinations

    public static T NumberOfCombinations<T>(T numberOfItemsInSet, T sizeOfCombinations) where T : INumber<T>
    {
        if (numberOfItemsInSet.IsLessThan(sizeOfCombinations) == true)
            throw new ArgumentOutOfRangeException(nameof(sizeOfCombinations),
                "numberOfItemsInSet must be greater than or equal to sizeOfCombinations.");

        return Div(
                Factorial(numberOfItemsInSet),
                Mul(
                    Factorial(sizeOfCombinations), 
                    Factorial(Sub(numberOfItemsInSet, sizeOfCombinations))
                    )
                );
    }

    #endregion

    #region Time

    public static long MillSecToSec(long milliSeconds)
        => milliSeconds / 1000;

    public static long MillSecToMin(long milliSeconds)
        => MillSecToSec(milliSeconds) / 60;

    public static long MillSecToHour(long milliSeconds)
        => MillSecToMin(milliSeconds) / 60;

    public static long MillSecToDay(long milliSeconds)
        => MillSecToHour(milliSeconds) / 24;

    public static long MillSecToWeek(long milliSeconds)
        => MillSecToDay(milliSeconds) / 7;

    #endregion

    #region IsBetween

    public static bool IsBetween<T>(this T input, T lowerBound, T upperBound, bool leftInclusive = true,
        bool rightInclusive = true) where T : INumber<T>
    {
        var left = leftInclusive ? input.IsGreaterThanOrEqualTo(lowerBound) : input.IsGreaterThan(lowerBound) ?? false;
        var right = rightInclusive ? input.IsLessThanOrEqualTo(upperBound) : input.IsLessThan(upperBound) ?? false;

        return left && right;
    }

    #endregion

    #region ManhattanDistance

    public static T ManhattanDistance<T>((T,T) point1, (T,T) point2) where T : INumber<T>
    {
        var x = Abs(Sub(point1.Item1, point2.Item1));
        var y = Abs(Sub(point1.Item2, point2.Item2));

        return Add(x, y);
    }

    #endregion

    #region Abs
    
    public static T Abs<T>(T a) where T : INumber<T>
        => a.IsNegative() ? Sub(T.Zero, a) : a;

    #endregion

    #region IsNegative

    public static bool IsNegative<T>(this T a) where T : INumber<T>
        => a.IsLessThan(T.Zero) == true;

    #endregion
}