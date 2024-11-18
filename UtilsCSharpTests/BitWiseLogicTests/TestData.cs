namespace UtilsCSharpTests.BitWiseLogicTests;

public class TestData
{
    public static object[] NOT { get; } =
    {
        // {expected, left, right}
        new object[] {"1111", "0000"},
        new object[] {"1110", "0001"},
        new object[] {"1101", "0010"},
        new object[] {"1100", "0011"},
        new object[] {"1011", "0100"},
        new object[] {"1010", "0101"},
        new object[] {"1001", "0110"},
        new object[] {"1000", "0111"},
        new object[] {"0111", "1000"},
        new object[] {"0110", "1001"},
        new object[] {"0101", "1010"},
        new object[] {"0100", "1011"},
        new object[] {"0011", "1100"},
        new object[] {"0010", "1101"},
        new object[] {"0001", "1110"},
        new object[] {"0000", "1111"},
    };

    public static object[] XOR { get; } =
    {
        // {expected, left, right}
        new object[] {false, false, false},
        new object[] {true, true, false},
        new object[] {true, false, true},
        new object[] {false, true, true}
    };

    public static object[] XORChar { get; } =
    {
        // {expected, left, right}
        new object[] {'0', '0', '0'},
        new object[] {'1', '1', '0'},
        new object[] {'1', '0', '1'},
        new object[] {'0', '1', '1'}
    };

    public static object[] XorString { get; } =
    {
        // {expected, left, right}
        #region 0000
        new object[] {"0000", "0000", "0000"},
        new object[] {"0000", "0001", "0001"},
        new object[] {"0000", "0010", "0010"},
        new object[] {"0000", "0011", "0011"},
        new object[] {"0000", "0100", "0100"},
        new object[] {"0000", "0101", "0101"},
        new object[] {"0000", "0110", "0110"},
        new object[] {"0000", "0111", "0111"},
        new object[] {"0000", "1000", "1000"},
        new object[] {"0000", "1001", "1001"},
        new object[] {"0000", "1010", "1010"},
        new object[] {"0000", "1011", "1011"},
        new object[] {"0000", "1100", "1100"},
        new object[] {"0000", "1101", "1101"},
        new object[] {"0000", "1110", "1110"},
        new object[] {"0000", "1111", "1111"},
        #endregion
        #region 0001
        new object[] {"0001", "0000", "0001"},
        new object[] {"0001", "0001", "0000"},
        new object[] {"0001", "0010", "0011"},
        new object[] {"0001", "0011", "0010"},
        new object[] {"0001", "0100", "0101"},
        new object[] {"0001", "0101", "0100"},
        new object[] {"0001", "0110", "0111"},
        new object[] {"0001", "0111", "0110"},
        new object[] {"0001", "1000", "1001"},
        new object[] {"0001", "1001", "1000"},
        new object[] {"0001", "1010", "1011"},
        new object[] {"0001", "1011", "1010"},
        new object[] {"0001", "1100", "1101"},
        new object[] {"0001", "1101", "1100"},
        new object[] {"0001", "1110", "1111"},
        new object[] {"0001", "1111", "1110"},
        #endregion
        #region 0010
        new object[] {"0010", "0000", "0010"},
        new object[] {"0010", "0001", "0011"},
        new object[] {"0010", "0010", "0000"},
        new object[] {"0010", "0011", "0001"},
        new object[] {"0010", "0100", "0110"},
        new object[] {"0010", "0101", "0111"},
        new object[] {"0010", "0110", "0100"},
        new object[] {"0010", "0111", "0101"},
        new object[] {"0010", "1000", "1010"},
        new object[] {"0010", "1001", "1011"},
        new object[] {"0010", "1010", "1000"},
        new object[] {"0010", "1011", "1001"},
        new object[] {"0010", "1100", "1110"},
        new object[] {"0010", "1101", "1111"},
        new object[] {"0010", "1110", "1100"},
        new object[] {"0010", "1111", "1101"},
        #endregion
        #region 0011
        new object[] {"0011", "0000", "0011"},
        new object[] {"0011", "0001", "0010"},
        new object[] {"0011", "0010", "0001"},
        new object[] {"0011", "0011", "0000"},
        new object[] {"0011", "0100", "0111"},
        new object[] {"0011", "0101", "0110"},
        new object[] {"0011", "0110", "0101"},
        new object[] {"0011", "0111", "0100"},
        new object[] {"0011", "1000", "1011"},
        new object[] {"0011", "1001", "1010"},
        new object[] {"0011", "1010", "1001"},
        new object[] {"0011", "1011", "1000"},
        new object[] {"0011", "1100", "1111"},
        new object[] {"0011", "1101", "1110"},
        new object[] {"0011", "1110", "1101"},
        new object[] {"0011", "1111", "1100"},
        #endregion
        #region 0100
        new object[] {"0100", "0000", "0100"},
        new object[] {"0100", "0001", "0101"},
        new object[] {"0100", "0010", "0110"},
        new object[] {"0100", "0011", "0111"},
        new object[] {"0100", "0100", "0000"},
        new object[] {"0100", "0101", "0001"},
        new object[] {"0100", "0110", "0010"},
        new object[] {"0100", "0111", "0011"},
        new object[] {"0100", "1000", "1100"},
        new object[] {"0100", "1001", "1101"},
        new object[] {"0100", "1010", "1110"},
        new object[] {"0100", "1011", "1111"},
        new object[] {"0100", "1100", "1000"},
        new object[] {"0100", "1101", "1001"},
        #endregion
    };
}