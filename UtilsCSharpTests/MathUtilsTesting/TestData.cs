using UtilsCSharpTests.Utils;

namespace UtilsCSharpTests.MathUtilsTesting;

public static class TestData
{
    public static object[] AddCasesNumbers { get; } =
    {
        // {expected, first, second}
        new object[] {5, 3, 2},
        new object[] {5L, 3L, 2L},
        new object[] {5.55, 3.21, 2.34}
    };

    public static object[] AddCasesEnumerable { get; } =
    {
        // {expected, numbers, seed, constant}
        new object[] {10, new List<int> {1, 2, 3, 4}, 0, 0},
        new object[] {10L, new List<long> {1L, 2L, 3L, 4L}, 0L, 0L},
        new object[] {10.0, new List<double> {1D, 2D, 3D, 4D}, 0D, 0D},
        new object[] {15,new List<int> {1, 2, 3, 4}, 5, 0},
        new object[] {15, new List<long> {1L, 2L, 3L, 4L}, 5L, 0L},
        new object[] {15, new List<double> {1D, 2D, 3D, 4D}, 5D, 0D},
        new object[] {39, new List<int> {1, 2, 3, 4}, 5, 6},
        new object[] {39, new List<long> {1L, 2L, 3L, 4L}, 5L, 6L},
        new object[] {39, new List<double> {1D, 2D, 3D, 4D}, 5D, 6D}
    };
    
    public static object[] SubtractCasesNumbers { get; } =
    {
        // {expected, first, second}
        new object[] {1, 3, 2, null},
        new object[] {1L, 3L, 2L, null},
        new object[] {0.87, 3.21, 2.34, 2}
    };
    
    public static object[] MultiplyCasesNumbers { get; } =
    {
        // {expected, first, second}
        new object[] {6, 3, 2, null},
        new object[] {6L, 3L, 2L, null},
        new object[] {7.527, 3.21, 2.345, 3}
    };
    
    public static object[] DivideCasesNumbers { get; } =
    {
        // {expected, first, second}
        new object[] {1, 3, 2, null},
        new object[] {1L, 3L, 2L, null},
        new object[] {0, 3, 0, null},
        new object[] {0L, 3L, 0L, null},
        new object[] {1.37, 3.21, 2.34, 2},
        new object[] {1.5, 3.0, 2.0, 2}
    };
    
    public static object[] GcdCases { get; } =
    {
        // {expected, first, second}
        new object[] {3, 12, 9},
        new object[] {3L, 12L, 9L},
        new object[] {3.0, 12.0, 9.0},
        new object[] {1, 0, 0},
        new object[] {1L, 0L, 0L},
        new object[] {1.0, 0.0, 0.0}
    };

    public static object[] LcmCases { get; } =
    {
        // {expected, first, second}
        new object[] {36, 12, 9},
        new object[] {36L, 12L, 9L},
        new object[] {36.0, 12.0, 9.0}
    };


    public static object[] LcmEnumerableCases { get; } =
    {
        // {expected, numbers}
        new object[] {36, new List<int> {12, 9}},
        new object[] {36L, new List<long> {12L, 9L}},
        new object[] {36.0, new List<double> {12D, 9D}},
        new object[] {228300182686739, new List<long>{3911,3917,3929,3793}}
    };
    
    public static object[] IsPrime { get; } =
    {
        // {expected, first}
        new object[] {true, 7},
        new object[] {false, 9},
        new object[] {true, 7L},
        new object[] {false, 9L},
        new object[] {true, 7D},
        new object[] {false, 9D}
    };
    
    public static object[] PythagoreanTheorem { get; } =
    {
        // {expected, a, b, precision}
        new object[] {5, 3, 4, null},
        new object[] {5L, 3L, 4L, null},
        new object[] {5.0, 3.0, 4.0, null},
        new object[] {5.2202, 4.2, 3.1, 4}
    };

    public static object[] Discriminant { get; } =
    {
        // {expected, a, b, c, precision}
        new object[] {-23, 2, 3, 4, null},
        new object[] {-23L, 2L, 3L, 4L, null},
        new object[] {-23.0, 2.0, 3.0, 4.0, 2},
    };

    public static object[] Factorial { get; } =
    {
        // {expected, first}
        new object[] {120, 5},
        new object[] {1, 0},
        new object[] {0, -5},
        new object[] {120L, 5L},
        new object[] {1L, 0L},
        new object[] {0L, -5L},
        new object[] {120D, 5D},
        new object[] {1D, 0D},
        new object[] {0D, -5D}
    };

    public static object[] NumberOfCombinations { get; } =
    {
        // {expected, first, second}
        new object[] {36, 9, 2},
        new object[] {36L, 9L, 2L},
        new object[] {36.0, 9.0, 2.0},
        new object[] {36, 2, 9},
        new object[] {36L, 2L, 9L},
        new object[] {36.0, 2.0, 9.0}
    };

    public static object[] MillSecToSec { get; } =
    {
        // {expected, first}
        new object[] {0.001, 1},
        new object[] {0.001, 1L},
        new object[] {0.001, 1D},
        new object[] {1, 1000},
        new object[] {1L, 1000L},
        new object[] {1D, 1000D}
    };
    
    public static object[] MillSecToMin { get; } =
    {
        // {expected, first}
        new object[] {1, 60000},
        new object[] {1L, 60000L},
        new object[] {1D, 60000D}
    };
    
    public static object[] MillSecToHour { get; } =
    {
        // {expected, first}
        new object[] {1, 3600000},
        new object[] {1L, 3600000L},
        new object[] {1D, 3600000D}
    };
    
    public static object[] MillSecToDay { get; } =
    {
        // {expected, first}
        new object[] {1, 86400000},
        new object[] {1L, 86400000L},
        new object[] {1D, 86400000D}
    };
    
    public static object[] MillSecToWeek { get; } =
    {
        // {expected, first}
        new object[] {1, 604800000},
        new object[] {1L, 604800000L},
        new object[] {1D, 604800000D}
    };
    
    public static object[] SecToMillSec { get; } =
    {
        // {expected, first}
        new object[] {1000, 1},
        new object[] {1000L, 1L},
        new object[] {1000D, 1D}
    };
    
    public static object[] SecToMin { get; } =
    {
        // {expected, first}
        new object[] {1, 60},
        new object[] {1L, 60L},
        new object[] {1D, 60D}
    };
    
    public static object[] SecToHour { get; } =
    {
        // {expected, first}
        new object[] {1, 3600},
        new object[] {1L, 3600L},
        new object[] {1D, 3600D}
    };
    
    public static object[] SecToDay { get; } =
    {
        // {expected, first}
        new object[] {1, 86400},
        new object[] {1L, 86400L},
        new object[] {1D, 86400D}
    };
    
    public static object[] SecToWeek { get; } =
    {
        // {expected, first}
        new object[] {1, 604800},
        new object[] {1L, 604800L},
        new object[] {1D, 604800D}
    };
    
    public static object[] MinToMillSec { get; } =
    {
        // {expected, first}
        new object[] {60000, 1},
        new object[] {60000L, 1L},
        new object[] {60000D, 1D}
    };
    
    public static object[] MinToSec { get; } =
    {
        // {expected, first}
        new object[] {60, 1},
        new object[] {60L, 1L},
        new object[] {60D, 1D}
    };
    
    public static object[] MinToHour { get; } =
    {
        // {expected, first}
        new object[] {1, 60},
        new object[] {1L, 60L},
        new object[] {1D, 60D}
    };
    
    public static object[] MinToDay { get; } =
    {
        // {expected, first}
        new object[] {1, 1440},
        new object[] {1L, 1440L},
        new object[] {1D, 1440D}
    };
    
    public static object[] MinToWeek { get; } =
    {
        // {expected, first}
        new object[] {1, 10080},
        new object[] {1L, 10080L},
        new object[] {1D, 10080D}
    };
    
    public static object[] HourToMillSec { get; } =
    {
        // {expected, first}
        new object[] {3600000, 1},
        new object[] {3600000L, 1L},
        new object[] {3600000D, 1D}
    };
    
    public static object[] HourToSec { get; } =
    {
        // {expected, first}
        new object[] {3600, 1},
        new object[] {3600L, 1L},
        new object[] {3600D, 1D}
    };
    
    public static object[] HourToMin { get; } =
    {
        // {expected, first}
        new object[] {60, 1},
        new object[] {60L, 1L},
        new object[] {60D, 1D}
    };
    
    public static object[] HourToDay { get; } =
    {
        // {expected, first}
        new object[] {1, 24},
        new object[] {1L, 24L},
        new object[] {1D, 24D}
    };
    
    public static object[] HourToWeek { get; } =
    {
        // {expected, first}
        new object[] {1, 168},
        new object[] {1L, 168L},
        new object[] {1D, 168D}
    };
    
    public static object[] ManhattanDistance { get; } =
    {
        // {expected, (x1, y1), (x2, y2)}
        new object[] {2, (1, 1), (2, 2)},
        new object[] {2L, (1L, 1L), (2L, 2L)},
        new object[] {2.0, (1.0, 1.0), (2.0, 2.0)}
    };
    
    public static object[] IsNegative { get; } =
    {
        // {expected, first}
        new object[] {true, -5},
        new object[] {false, 5},
        new object[] {false, 0},
        new object[] {true, -5L},
        new object[] {false, 5L},
        new object[] {false, 0},
        new object[] {true, -5D},
        new object[] {false, 5D},
        new object[] {false, 0D}
    };
    
    public static object[] IsPositive { get; } =
    {
        // {expected, first}
        new object[] {false, -5},
        new object[] {true, 5},
        new object[] {false, 0},
        new object[] {false, -5L},
        new object[] {true, 5L},
        new object[] {false, 0},
        new object[] {false, -5D},
        new object[] {true, 5D},
        new object[] {false, 0D}
    };
    
    public static object[] Abs { get; } =
    {
        // {expected, first}
        new object[] {5, -5},
        new object[] {5, 5},
        new object[] {0, 0},
        new object[] {5L, -5L},
        new object[] {5L, 5L},
        new object[] {0L, 0L},
        new object[] {5D, -5D},
        new object[] {5D, 5D},
        new object[] {0D, 0D}
    };
}