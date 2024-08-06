using UtilsCSharpTests.Utils;

namespace UtilsCSharpTests.ComparisonsTesting;

public class TestData
{
    public static object[] GetHighest { get; } =
    {
        // {expected, first, second}
        new object[]{12, 12, 9},
        new object[]{12, 9, 12},
        new object[]{12, 12, 12},
        new object[]{12L, 12L, 9L},
        new object[]{12L, 9L, 12L},
        new object[]{12L, 12L, 12L},
        new object[]{12D, 12D, 9D},
        new object[]{12D, 9D, 12D},
        new object[]{12D, 12D, 12D}
    };

    public static object[] GetLowest { get; } =
    {
        // {expected, first, second}
        new object[]{9, 12, 9},
        new object[]{9, 9, 12},
        new object[]{9, 9, 9},
        new object[]{9L, 12L, 9L},
        new object[]{9L, 9L, 12L},
        new object[]{9L, 9L, 9L},
        new object[]{9D, 12D, 9D},
        new object[]{9D, 9D, 12D},
        new object[]{9D, 9D, 9D}
    };

    public static object[] IsEven { get; } =
    {
        // {expected, first}
        new object[] {true, 12},
        new object[] {false, 9},
        new object[] {true, 12L},
        new object[] {false, 9L},
        new object[] {true, 12D},
        new object[] {false, 9D}
    };
    
    public static object[] IsOdd { get; } =
    {
        // {expected, first}
        new object[] {true, 9},
        new object[] {false, 12},
        new object[] {true, 9L},
        new object[] {false, 12L},
        new object[] {true, 9D},
        new object[] {false, 12D}
    };
    
    public static object[] IsGreaterThan { get; } =
    {
        // {expected, first, second}
        new object[] {true, 5, 3},
        new object[] {false, 5, 5},
        new object[] {false, 3, 5},
        new object[] {true, 5L, 3L},
        new object[] {false, 5L, 5L},
        new object[] {false, 3L, 5L},
        new object[] {true, 5D, 3D},
        new object[] {false, 5D, 5D},
        new object[] {false, 3D, 5D}
    };

    public static object[] IsSmallerThan { get; } =
    {
        // {expected, first, second}
        new object[] {false, 5, 3},
        new object[] {false, 5, 5},
        new object[] {true, 3, 5},
        new object[] {false, 5L, 3L},
        new object[] {false, 5L, 5L},
        new object[] {true, 3L, 5L},
        new object[] {false, 5D, 3D},
        new object[] {false, 5D, 5D},
        new object[] {true, 3D, 5D}
    };

    public static object[] IsGreaterThanOrEqualTo { get; } =
    {
        // {expected, first, second}
        new object[] {true, 5, 3},
        new object[] {true, 5, 5},
        new object[] {false, 3, 5},
        new object[] {true, 5L, 3L},
        new object[] {true, 5L, 5L},
        new object[] {false, 3L, 5L},
        new object[] {true, 5D, 3D},
        new object[] {true, 5D, 5D},
        new object[] {false, 3D, 5D}
    };
    
    public static object[] IsLessThanOrEqualTo { get; } =
    {
        // {expected, first, second}
        new object[] {false, 5, 3},
        new object[] {true, 5, 5},
        new object[] {true, 3, 5},
        new object[] {false, 5L, 3L},
        new object[] {true, 5L, 5L},
        new object[] {true, 3L, 5L},
        new object[] {false, 5D, 3D},
        new object[] {true, 5D, 5D},
        new object[] {true, 3D, 5D}
    };

    public static object[] IsBetween { get; } =
    {
        // {expected, first, lowerBound, upperBound, leftInclusive, rightInclusive}
        new object[] {true, 5, 3, 7, Constants.Inclusive, Constants.Inclusive},
        new object[] {false, 2, 3, 7, Constants.Inclusive, Constants.Inclusive},
        new object[] {true, 3, 3, 7, Constants.Inclusive, Constants.Inclusive},
        new object[] {true, 7, 3, 7, Constants.Inclusive, Constants.Inclusive},
        new object[] {true, 3, 3, 3, Constants.Inclusive, Constants.Inclusive},
        new object[] {true, 5, 3, 7, Constants.Inclusive, Constants.Exclusive},
        new object[] {false, 2, 3, 7, Constants.Inclusive, Constants.Exclusive},
        new object[] {true, 3, 3, 7, Constants.Inclusive, Constants.Exclusive},
        new object[] {false, 7, 3, 7, Constants.Inclusive, Constants.Exclusive},
        new object[] {false, 3, 3, 3, Constants.Inclusive, Constants.Exclusive},
        new object[] {true, 5, 3, 7, Constants.Exclusive, Constants.Inclusive},
        new object[] {false, 2, 3, 7, Constants.Exclusive, Constants.Inclusive},
        new object[] {false, 3, 3, 7, Constants.Exclusive, Constants.Inclusive},
        new object[] {true, 7, 3, 7, Constants.Exclusive, Constants.Inclusive},
        new object[] {false, 3, 3, 3, Constants.Exclusive, Constants.Inclusive},
        new object[] {true, 5, 3, 7, Constants.Exclusive, Constants.Exclusive},
        new object[] {false, 2, 3, 7, Constants.Exclusive, Constants.Exclusive},
        new object[] {false, 3, 3, 7, Constants.Exclusive, Constants.Exclusive},
        new object[] {false, 7, 3, 7, Constants.Exclusive, Constants.Exclusive}
    };

    public static object[] Intersects { get; } =
    {
        // {expected, range 1, range 2}
        new object[]{true, new Range(0,5), new Range(2,6)},
        new object[]{true, new Range(2,6), new Range(0,5)},
        new object[]{true, new Range(0,5), new Range(0,5)},
        new object[]{true, new Range(0,5), new Range(5,10)},
        new object[]{true, new Range(5,10), new Range(0,5)},
        new object[]{false, new Range(0,5), new Range(6,10)},
        new object[]{false, new Range(6,10), new Range(0,5)}
    };
}