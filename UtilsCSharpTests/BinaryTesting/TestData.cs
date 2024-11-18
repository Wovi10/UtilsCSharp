namespace UtilsCSharpTests.BinaryTesting;

public class TestData
{
    public static object[] BcdToBinary { get; } =
    {
        // {expected, bcd}
        new object[] {"01100111", "0001_0000_0011"},
    };

    public static object[] BinaryToBcd { get; } =
    {
        // {expected, binary}
        new object[] {"000100000011", "0110_0111"},
    };

    public static object[] MaskBinaryString { get; } =
    {
        // {expected, unmasked binaryString}
        new object[] {"0111", "111"},
        new object[] {"00010110", "1_0110"},
        new object[] {"000100000110", "1_0000_0110"},
        new object[] {"00010110", "10110"}
    };

    public static object[] AddNibbleUnderscores { get; } =
    {
        // {expected, binaryString}
        new object[] {"0111", "0111"},
        new object[] {"0001_0110", "00010110"},
        new object[] {"0001_0000_0110", "000100000110"},
        new object[] {"001_0110", "0010110"}
    };

    public static object[] ToBinaryString { get; } =
    {
        // {expected, number}
        new object[] {"111", 7},
        new object[] {"10110", 22},
        new object[] {"100000110", 262},
        new object[] {"10110", 22}
    };
}