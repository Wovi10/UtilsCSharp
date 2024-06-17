using System.Numerics;

namespace UtilsCSharp;

public static class Comparisons
{
    #region GetHighest

    public static T GetHighest<T>(T a, T b) where T: struct, IComparable<T>
        => a.CompareTo(b) > 0 ? a : b;

    #endregion
    
    #region GetLowest

    public static T GetLowest<T>(T a, T b) where T: struct, IComparable<T>
        => a.CompareTo(b) < 0 ? a : b;

    #endregion

    #region IsEven

    public static bool IsEven<T>(this T a) where T: struct, INumber<T>
        => T.IsEvenInteger(a);

    #endregion

    #region IsOdd

    public static bool IsOdd<T>(this T a) where T: struct, INumber<T>
        => T.IsOddInteger(a);

    #endregion

    #region IsGreaterThan

    public static bool IsGreaterThan<T>(this T a, T b) where T: struct, IComparable<T>
    {
        return a.CompareTo(b) switch
        {
            > 0 => true,
            _ => false
        };
    }

    public static bool IsBiggerThan<T>(this T a, T b) where T: struct, IComparable<T>
        => a.IsGreaterThan(b);

    #endregion

    #region IsLessThan

    public static bool IsLessThan<T>(this T a, T b) where T: struct, IComparable<T>
    {
        return a.CompareTo(b) switch
        {
            < 0 => true,
            _ => false
        };
    }
    
    public static bool IsSmallerThan<T>(this T a, T b) where T: struct, IComparable<T>
        => a.IsLessThan(b);

    #endregion
    
    #region IsGreaterThanOrEqualTo

    public static bool IsGreaterThanOrEqualTo<T>(this T a, T b) where T: struct, IComparable<T>
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

    public static bool IsLessThanOrEqualTo<T>(this T a, T b) where T: struct, IComparable<T>
    {
        return a.CompareTo(b) switch
        {
            < 0 => true,
            > 0 => false,
            _ => true
        };
    }
    
    public static bool IsSmallerOrEqualTo<T>(this T a, T b) where T: struct, IComparable<T>
        => a.IsLessThanOrEqualTo(b);

    #endregion

    #region IsBetween

    public static bool IsBetween<T>(this T input, T lowerBound, T upperBound, bool leftInclusive = true,
        bool rightInclusive = true) where T: struct, IComparable<T>
    {
        var left = 
            leftInclusive
                ? IsGreaterThanOrEqualTo(input,lowerBound)
                : IsGreaterThan(input, lowerBound);

        var right = 
            rightInclusive 
                ? IsLessThanOrEqualTo(input, upperBound)
                : IsLessThan(input, upperBound);

        return left && right;
    }

    #endregion
}