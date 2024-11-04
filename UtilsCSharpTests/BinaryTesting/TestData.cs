namespace UtilsCSharpTests.BinaryTesting;

public class TestData
{
    public static object[] BCDToBinary { get; } =
    {
        // {expected, bcd}
        new object[] {64, "0000_0110_0100"},
    };

    public static object[] BinaryToBCD { get; } =
    {
        // {expected, binary}
        new object[] {"0001_0000_0011", "0110_0111"},
    };
}