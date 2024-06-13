using System.Numerics;
using UtilsCSharp.Utils;

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

    public static T Gcd(T a, T b)
    {
        while (true)
        {
            if (a == T.Zero && b == T.Zero) return T.One;
            if (b == T.Zero) return a;
            var a1 = a;
            a = b;
            b = a1 % b;
        }
    }

    #endregion

    #region Least Common Multiple
    
    public static T Lcm(T a, T b)
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
        var fourA_C = Mul(T.CreateChecked(4), Mul(a, c));

        if (returnPrecision == null)
            return bSquared - fourA_C;
        
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

    public static bool IsGreaterThan(T a, T b)
    {
        return a.CompareTo(b) switch
        {
            > 0 => true,
            _ => false
        };
    }

    public static bool? IsBiggerThan(T a, T b)
        => IsGreaterThan(a, b);
    
    #endregion

    #region IsLessThan

    public static bool IsLessThan(T a, T b)
    {
        return a.CompareTo(b) switch
        {
            < 0 => true,
            _ => false
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


    public static T MillSecToSec(T milliSeconds)
        => Div(milliSeconds, T.CreateChecked(Constants.MillSecInSec));

    public static T MillSecToMin(T milliSeconds)
        => Div(MillSecToSec(milliSeconds), T.CreateChecked(Constants.SecInMin));

    public static T MillSecToHour(T milliSeconds)
        => Div(MillSecToMin(milliSeconds), T.CreateChecked(Constants.MinInHour));

    public static T MillSecToDay(T milliSeconds)
        => Div(MillSecToHour(milliSeconds), T.CreateChecked(Constants.HourInDay));

    public static T MillSecToWeek(T milliSeconds)
        => Div(MillSecToDay(milliSeconds), T.CreateChecked(Constants.DayInWeek));

    public static T SecToMillSec(T seconds)
        => Mul(seconds, T.CreateChecked(Constants.MillSecInSec));
    
    public static T SecToMin(T seconds)
        => Div(seconds, T.CreateChecked(Constants.SecInMin));
    
    public static T SecToHour(T seconds)
        => Div(SecToMin(seconds), T.CreateChecked(Constants.MinInHour));
    
    public static T SecToDay(T seconds)
        => Div(SecToHour(seconds), T.CreateChecked(Constants.HourInDay));
    
    public static T SecToWeek(T seconds)
        => Div(SecToDay(seconds), T.CreateChecked(Constants.DayInWeek));
    
    public static T MinToMillSec(T minutes)
        => Mul(MinToSec(minutes), T.CreateChecked(Constants.MillSecInSec));
    
    public static T MinToSec(T minutes)
        => Mul(minutes, T.CreateChecked(Constants.SecInMin));
    
    public static T MinToHour(T minutes)
        => Div(minutes, T.CreateChecked(Constants.MinInHour));
    
    public static T MinToDay(T minutes)
        => Div(MinToHour(minutes), T.CreateChecked(Constants.HourInDay));
    
    public static T MinToWeek(T minutes)
        => Div(MinToDay(minutes), T.CreateChecked(Constants.DayInWeek));
    
    public static T HourToMillSec(T hours)
        => Mul(HourToSec(hours), T.CreateChecked(Constants.MillSecInSec));
    
    public static T HourToSec(T hours)
        => Mul(HourToMin(hours), T.CreateChecked(Constants.SecInMin));
    
    public static T HourToMin(T hours)
        => Mul(hours, T.CreateChecked(Constants.MinInHour));
    
    public static T HourToDay(T hours)
        => Div(hours, T.CreateChecked(Constants.HourInDay));
    
    public static T HourToWeek(T hours)
        => Div(HourToDay(hours), T.CreateChecked(Constants.DayInWeek));
    
    #endregion

    #region IsBetween

    public static bool IsBetween(T input, T lowerBound, T upperBound, bool leftInclusive = true,
        bool rightInclusive = true)
    {
        var left = leftInclusive ? IsGreaterThanOrEqualTo(input,lowerBound) : IsGreaterThan(input, lowerBound);
        var right = rightInclusive ? IsLessThanOrEqualTo(input, upperBound) : IsLessThan(input, upperBound);

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