using System.Numerics;

namespace UtilsCSharp;

public static class MathUtils<T> where T: struct, INumber<T>, IComparable<T>
{
    #region Add

    public static T Add(T a, T b)
        => a + b;

    public static T Add(IEnumerable<T> list, T seed = default, T constant = default)
    {
        if (constant == T.Zero && seed == T.Zero)
            return list.Aggregate(Add);

        if (constant == T.Zero)
            return list.Aggregate(seed, Add);

        if (seed == T.Zero)
            return list.Aggregate((a, b) => Add(Add(a, b), constant));

        return list.Aggregate(seed, (a, b) => Add(Add(a, b), constant));
    }

    #endregion

    #region Subtract
    
    public static T Sub(T a, T b, int? precision = null)
    {
        if (precision == null)
            return a - b;
        
        var subAsDouble = double.CreateChecked(Sub(a, b));
        var rounded = Math.Round(subAsDouble, precision.Value);

        return T.CreateChecked(rounded);
    }

    #endregion

    #region Multiply

    public static T Mul(T a, T b, int? precision = null)
    {
        if(precision == null)
            return a * b;
        
        var mulAsDouble = double.CreateChecked(Mul(a, b));
        var rounded = Math.Round(mulAsDouble, precision.Value);

        return T.CreateChecked(rounded);
    }

    #endregion

    #region Divide

    public static T Div(T a, T b, int? precision = null)
    {
        if (T.IsZero(b))
            throw new DivideByZeroException();

        if (precision == null)
            return a / b;
        
        var divAsDouble = double.CreateChecked(Div(a, b));
        var rounded = Math.Round(divAsDouble, precision.Value);

        return T.CreateChecked(rounded);
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

    public static T GetHighest(T a, T b)
        => a.CompareTo(b) > 0 ? a : b;

    #endregion

    #region GetLowest

    public static T GetLowest(T a, T b)
        => a.CompareTo(b) < 0 ? a : b;

    #endregion

    #region IsEven

    public static bool IsEven(T a) =>
        T.IsEvenInteger(a);

    #endregion

    #region IsOdd

    public static bool IsOdd(T a)
        => T.IsOddInteger(a);

    #endregion

    #region IsPrime

    public static bool IsPrime(T a)
    {
        switch (a)
        {
            case <= 1:
                return false;
            case 2:
                return true;
        }

        if (IsEven(a))
            return false;

        for (var i = 3; i <= Math.Sqrt(double.CreateChecked(a)); i += 2)
            if (T.IsZero(a % T.CreateChecked(i)))
                return false;

        return true;
    }

    #endregion

    #region PythagoreanTheorem

    public static T PythagoreanTheorem(T a, T b, int? returnPrecision = null)
    {
        var squaredA = Mul(a, a);
        var squaredB = Mul(b, b);

        if (returnPrecision == null)
        {
            var added = Add(squaredA, squaredB);
            var addedAsDouble = double.CreateChecked(added);

            return T.CreateChecked(Math.Sqrt(addedAsDouble));
        }

        var pythagoreanTheoremAsDouble = double.CreateChecked(PythagoreanTheorem(a, b));
        var rounded = Math.Round(pythagoreanTheoremAsDouble, returnPrecision.Value);
        return T.CreateChecked(rounded);
    }

    #endregion

    #region Discrimant

    public static T Discriminant(T a, T b, T c, int? returnPrecision = null)
    {
        var bSquared = Mul(b, b);
        var fourAC = Mul(T.CreateChecked(4), Mul(a, c));

        if (returnPrecision == null)
            return bSquared - fourAC;
        
        var discriminantAsDouble = double.CreateChecked(Discriminant(a, b, c));
        var rounded = Math.Round(discriminantAsDouble, returnPrecision.Value);
        
        return T.CreateChecked(rounded);
    }

    #endregion

    #region Factorial

    public static T Factorial(T a)
    {
        if (IsNegative(a))
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

    public static bool? IsGreaterThan(T a, T b)
    {
        return a.CompareTo(b) switch
        {
            > 0 => true,
            < 0 => false,
            _ => null
        };
    }

    public static bool? IsBiggerThan(T a, T b)
        => IsGreaterThan(a, b);
    
    #endregion

    #region IsLessThan

    public static bool? IsLessThan(T a, T b)
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
    
    public static bool IsGreaterThanOrEqualTo(T a, T b)
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
    
    public static bool IsLessThanOrEqualTo(T a, T b)
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

    public static T NumberOfCombinations(T numberOfItemsInSet, T sizeOfCombinations)
    {
        if (IsLessThan(numberOfItemsInSet, sizeOfCombinations) == true)
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

    public static bool IsBetween(T input, T lowerBound, T upperBound, bool leftInclusive = true,
        bool rightInclusive = true)
    {
        var left = leftInclusive ? IsGreaterThanOrEqualTo(input,lowerBound) : IsGreaterThan(input, lowerBound) ?? false;
        var right = rightInclusive ? IsLessThanOrEqualTo(input, upperBound) : IsLessThan(input, upperBound) ?? false;

        return left && right;
    }

    #endregion

    #region ManhattanDistance

    public static T ManhattanDistance((T,T) point1, (T,T) point2)
    {
        var x = Abs(Sub(point1.Item1, point2.Item1));
        var y = Abs(Sub(point1.Item2, point2.Item2));

        return Add(x, y);
    }

    #endregion

    #region Abs
    
    public static T Abs(T a)
        => IsNegative(a) ? Sub(T.Zero, a) : a;

    #endregion

    #region IsNegative

    public static bool IsNegative(T a)
        => IsLessThan(a, T.Zero) == true;

    #endregion
}