using System.Globalization;

namespace UtilsCSharp;

public static class MathUtils
{
    #region Add

    /// <summary>
    /// Add two integers together.
    /// </summary>
    /// <param name="a">int</param>
    /// <param name="b">int</param>
    /// <returns>The sum of the two inputs</returns>
    public static int Add(int a, int b)
        => a + b;

    /// <summary>
    /// Add two longs together.
    /// </summary>
    /// <param name="a">long</param>
    /// <param name="b">long</param>
    /// <returns>The sum of the two inputs</returns>
    public static long Add(long a, long b)
        => a + b;

    /// <summary>
    /// Add two doubles together.
    /// </summary>
    /// <param name="a">double</param>
    /// <param name="b">double</param>
    /// <returns>The sum of the two inputs</returns>
    public static double Add(double a, double b)
        => a + b;

    /// <summary>
    /// Add two strings together.
    /// This will concatenate the input.
    /// </summary>
    /// <param name="a">string</param>
    /// <param name="b">string</param>
    /// <returns>The concatenated value of the two inputs.</returns>
    public static string Add(string a, string b)
        => $"{a}{b}";

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
    /// Subtract two integers.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Sub(int a, int b)
        => a - b;

    /// <summary>
    /// Subtract two longs.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static long Sub(long a, long b)
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
    /// Multiply two integers.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Mul(int a, int b)
        => a * b;

    /// <summary>
    /// Multiply two longs.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static long Mul(long a, long b)
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

    public static double Div(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException();
        return (double) a / (double) b;
    }

    public static double Div(long a, long b)
    {
        if (b == 0)
            throw new DivideByZeroException();
        return (double) a / (double) b;
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
    /// Greatest Common Dividor of two integers.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>
    /// The biggest number that can divide both a and b.
    /// 1 if both a and b are 0.
    /// </returns>
    public static int Gcd(int a, int b)
    {
        if (a == 0 && b == 0)
            return 1;
        return b == 0
            ? a
            : Gcd(b, a % b);
    }

    /// <summary>
    /// Greatest Common Dividor of two longs.
    /// The biggest number that can divide both a and b.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>
    /// The biggest number that can divide both a and b.
    /// 1 if both a and b are 0.
    /// </returns>
    public static long Gcd(long a, long b)
    {
        if (a == 0 && b == 0)
            return 1;
        return b == 0
            ? a
            : Gcd(b, a % b);
    }


    /// <summary>
    /// Greatest Common Dividor of two doubles.
    /// The biggest number that can divide both a and b.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>
    /// The biggest number that can divide both a and b.
    /// 1 if both a and b are 0.
    /// </returns>
    public static double Gcd(double a, double b)
    {
        if (a == 0 && b == 0)
            return 1;
        return b == 0
            ? a
            : Gcd(b, a % b);
    }

    #endregion

    #region Least Common Multiple

    /// <summary>
    /// Least Common Multiple of two integers.
    /// The lowest number that is a multiple of both a and b.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Lcm(int a, int b)
        => a * b / Gcd(a, b);

    /// <summary>
    /// Least Common Multiple of two longs.
    /// The lowest number that is a multiple of both a and b.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static long Lcm(long a, long b)
        => a * b / Gcd(a, b);

    /// <summary>
    /// Least Common Multiple of two doubles.
    /// The lowest number that is a multiple of both a and b.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static double Lcm(double a, double b)
        => a * b / Gcd(a, b);

    #endregion

    #region GetHighest

    public static int GetHighest(int a, int b)
        => a > b ? a : b;

    public static long GetHighest(long a, long b)
        => a > b ? a : b;

    public static double GetHighest(double a, double b)
        => a > b ? a : b;

    #endregion

    #region GetLowest

    public static int GetLowest(int a, int b)
        => a < b ? a : b;

    public static long GetLowest(long a, long b)
        => a < b ? a : b;

    public static double GetLowest(double a, double b)
        => a < b ? a : b;

    #endregion

    #region IsEven

    public static bool IsEven(this int a)
        => a % 2 == 0;

    public static bool IsEven(this long a)
        => a % 2 == 0;

    public static bool IsEven(this double a)
        => a % 2 == 0;

    #endregion

    #region IsOdd

    public static bool IsOdd(this int a)
        => a % 2 != 0;

    public static bool IsOdd(this long a)
        => a % 2 != 0;

    public static bool IsOdd(this double a)
        => a % 2 != 0;

    #endregion

    #region IsPrime

    public static bool IsPrime(this int a)
    {
        switch (a)
        {
            case <= 1:
                return false;
            case 2:
                return true;
        }

        if (a % 2 == 0)
            return false;
        for (var i = 3; i <= Math.Sqrt(a); i += 2)
            if (a % i == 0)
                return false;
        return true;
    }

    public static bool IsPrime(this long a)
    {
        switch (a)
        {
            case <= 1:
                return false;
            case 2:
                return true;
        }

        if (a % 2 == 0)
            return false;
        for (var i = 3; i <= Math.Sqrt(a); i += 2)
            if (a % i == 0)
                return false;
        return true;
    }

    public static bool IsPrime(this double a)
    {
        switch (a)
        {
            case <= 1:
                return false;
            case 2:
                return true;
        }

        if (a % 2 == 0)
            return false;
        for (var i = 3; i <= Math.Sqrt(a); i += 2)
            if (a % i == 0)
                return false;
        return true;
    }

    #endregion

    #region PythagoreanTheorem

    /// <summary>
    /// The Pythagorean theorem of integers.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>The square root of a squared + b squared</returns>
    public static double PythagoreanTheorem(int a, int b)
        => Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

    /// <summary>
    /// The Pythagorean theorem of longs.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>The square root of a squared + b squared</returns>
    public static double PythagoreanTheorem(long a, long b)
        => Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

    /// <summary>
    /// The Pythagorean theorem of doubles.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="returnPrecision">The desired precision of the return value. Ignored if empty.</param>
    /// <returns>The square root of a squared + b squared</returns>
    public static double PythagoreanTheorem(double a, double b, int? returnPrecision = null)
    {
        var squaredA = Math.Pow(a, 2);
        var squaredB = Math.Pow(b, 2);
        return returnPrecision == null
            ? Math.Sqrt(squaredA + squaredB)
            : Math.Round(Math.Sqrt(squaredA + squaredB), returnPrecision.Value);
    }

    #endregion

    #region Discrimant

    /// <summary>
    /// Discriminant of integers.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static double Discriminant(int a, int b, int c)
        => Math.Pow(b, 2) - 4 * a * c;

    /// <summary>
    /// Discriminant of longs.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static double Discriminant(long a, long b, long c)
        => Math.Pow(b, 2) - 4 * a * c;


    /// <summary>
    /// Discriminant of doubles.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <param name="returnPrecision"></param>
    /// <returns></returns>
    public static double Discriminant(double a, double b, double c, int? returnPrecision)
    {
        return returnPrecision == null
            ? Math.Pow(b, 2) - 4 * a * c
            : Math.Round(Math.Pow(b, 2) - 4 * a * c, returnPrecision.Value);
    }

    #endregion

    #region Factorial

    public static int Factorial(int a)
    {
        if (a < 0)
            throw new ArgumentOutOfRangeException(nameof(a), "Factorial of a negative number is undefined.");
        return a switch
        {
            0 => 1,
            1 => 1,
            _ => a * Factorial(a - 1)
        };
    }

    public static long Factorial(long a)
    {
        if (a < 0)
            throw new ArgumentOutOfRangeException(nameof(a), "Factorial of a negative number is undefined.");
        return a switch
        {
            0 => 1,
            1 => 1,
            _ => a * Factorial(a - 1)
        };
    }

    public static double Factorial(double a)
    {
        if (a < 0)
            throw new ArgumentOutOfRangeException(nameof(a), "Factorial of a negative number is undefined.");
        return a switch
        {
            0 => 1,
            1 => 1,
            _ => a * Factorial(a - 1)
        };
    }

    #endregion

    #region IsGreaterThan

    /// <summary>
    /// Compares two integers.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>True or false. Null if equal.</returns>
    public static bool? IsGreaterThan(this int a, int b)
    {
        return a > b
            ? true
            : a < b
                ? false
                : null;
    }


    /// <summary>
    /// Compares two longs.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>True or false. Null if equal.</returns>
    public static bool? IsGreaterThan(this long a, long b)
    {
        return a > b
            ? true
            : a < b
                ? false
                : null;
    }


    /// <summary>
    /// Compares two doubles.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>True or false. Null if equal.</returns>
    public static bool? IsGreaterThan(this double a, double b)
    {
        return a > b
            ? true
            : a < b
                ? false
                : null;
    }

    #endregion

    #region IsLessThan

    /// <summary>
    /// Compares two integers.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>True or false. Null if equal.</returns>
    public static bool? IsLessThan(this int a, int b)
    {
        return a < b
            ? true
            : a > b
                ? false
                : null;
    }


    /// <summary>
    /// Compares two longs.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>True or false. Null if equal.</returns>
    public static bool? IsLessThan(this long a, long b)
    {
        return a < b
            ? true
            : a > b
                ? false
                : null;
    }


    /// <summary>
    /// Compares two doubles.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>True or false. Null if equal.</returns>
    public static bool? IsLessThan(this double a, double b)
    {
        return a < b
            ? true
            : a > b
                ? false
                : null;
    }

    #endregion

    #region NumberOfCombinations

    public static long NumberOfCombinations(int numberOfItemsInSet, int sizeOfCombinations)
    {
        if (numberOfItemsInSet < sizeOfCombinations)
            throw new ArgumentOutOfRangeException(nameof(sizeOfCombinations),
                "numberOfItemsInSet must be greater than or equal to sizeOfCombinations.");
        return Factorial(numberOfItemsInSet) /
               (Factorial(sizeOfCombinations) * Factorial(numberOfItemsInSet - sizeOfCombinations));
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

    public static bool IsBetween(this int a, int lowerBound, int upperBound, bool inclusive = true)
    {
        return inclusive 
            ? a >= lowerBound && a <= upperBound 
            : a > lowerBound && a < upperBound;
    }
    
    public static bool IsBetween(this long a, long lowerBound, long upperBound, bool inclusive = true)
    {
        return inclusive 
            ? a >= lowerBound && a <= upperBound 
            : a > lowerBound && a < upperBound;
    }
    
    public static bool IsBetween(this double a, double lowerBound, double upperBound, bool inclusive = true)
    {
        return inclusive 
            ? a >= lowerBound && a <= upperBound 
            : a > lowerBound && a < upperBound;
    }

    #endregion
}