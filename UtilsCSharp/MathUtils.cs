using System.Globalization;

namespace UtilsCSharp;

public static class MathUtils
{
    #region Add

    /// <summary>
    /// Add two integers together.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Add(int a, int b) 
        => a + b;

    /// <summary>
    /// Add two longs together.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static long Add(long a, long b)
        => a + b;

    /// <summary>
    /// Add two doubles together.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static double Add(double a, double b)
        => a + b;

    /// <summary>
    /// Add two strings together.
    /// This will check if the strings can be added together in any numerical type. If not, it will concatenate.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static string Add(string a, string b)
    {
        if (int.TryParse(a, out var aInt) && int.TryParse(b, out var bInt))
            return Add(aInt, bInt).ToString();
        if (long.TryParse(a, out var aLong) && long.TryParse(b, out var bLong))
            return Add(aLong, bLong).ToString();
        if (double.TryParse(a, out var aDouble) && double.TryParse(b, out var bDouble))
            return Add(aDouble, bDouble).ToString(CultureInfo.InvariantCulture);

        return $"{a}{b}";
    }

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
    /// <returns></returns>
    public static double Sub(double a, double b)
        => a - b;

    #endregion

    #region Greatest Common Factor

    /// <summary>
    /// Greatest Common Factor of two integers.
    /// The biggest number that can divide both a and b.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Gcf(int a, int b)
    {
        if (a == 0 && b == 0)
            return 1;
        return b == 0
            ? a
            : Gcf(b, a % b);
    }

    /// <summary>
    /// Greatest Common Factor of two longs.
    /// The biggest number that can divide both a and b.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static long Gcf(long a, long b)
    {
        if (a == 0 && b == 0)
            return 1;
        return b == 0
            ? a
            : Gcf(b, a % b);
    }

    
    /// <summary>
    /// Greatest Common Factor of two doubles.
    /// The biggest number that can divide both a and b.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static double Gcf(double a, double b)
    {
        if (a == 0 && b == 0)
            return 1;
        return b == 0
                ? a
                : Gcf(b, a % b);
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
        => a * b / Gcf(a, b);

    /// <summary>
    /// Least Common Multiple of two longs.
    /// The lowest number that is a multiple of both a and b.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static long Lcm(long a, long b)
        => a * b / Gcf(a, b);

    /// <summary>
    /// Least Common Multiple of two doubles.
    /// The lowest number that is a multiple of both a and b.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static double Lcm(double a, double b)
        => a * b / Gcf(a, b);

    #endregion

    #region GetHighest

    public static int GetHighest(int a, int b)
        => a > b ? a : b;
    
    

    #endregion
}