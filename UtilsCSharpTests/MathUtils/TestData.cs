namespace UtilsCSharpTests.MathUtils;

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
}