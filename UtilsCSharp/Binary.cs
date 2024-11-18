using System.Text;
using UtilsCSharp.Utils;

namespace UtilsCSharp;

public static class Binary
{
    public static string BcdToBinary(this string bcd)
    {
        var bcdArray = bcd.Split('_');

        return bcdArray
                .Select(bcdNumber => Convert.ToInt32(bcdNumber, 2))
                .Select((binaryNumber, i) => binaryNumber * (int)Math.Pow(10, bcdArray.Length - 1 - i))
                .Sum()
                .ToBinaryString()
                .MaskBinaryString();
    }

    public static string BinaryToBcd(this string binary)
    {
        var binaryString = binary;
        binaryString = binaryString.Replace(Constants.UnderScore, string.Empty);

        var bcd2 = new StringBuilder();
        var bcd1 = new StringBuilder();
        var bcd0 = new StringBuilder();

        foreach (var current in binaryString)
        {
            ShiftIntoBcd(current, bcd0, bcd1, bcd2);
            CheckForGreaterThanFive(bcd0, bcd1, bcd2);
        }

        var bcd2Value = PadToNibble(bcd2.ToString());
        var bcd1Value = PadToNibble(bcd1.ToString());
        var bcd0Value = PadToNibble(bcd0.ToString());

        return $"{bcd2Value}{bcd1Value}{bcd0Value}";
    }

    public static string MaskBinaryString(this string binaryString)
    {
        var cleanedBinaryString = binaryString.Replace(Constants.UnderScore, string.Empty);

        var leastAmountOfCompleteNibbles = (int)Math.Ceiling(cleanedBinaryString.Length / 4.0) - 1;

        var possibleIncompleteNibbleLength = cleanedBinaryString.Length - leastAmountOfCompleteNibbles * 4;

        var completeNibbles = cleanedBinaryString[possibleIncompleteNibbleLength..];
        var incompleteNibble = cleanedBinaryString[..possibleIncompleteNibbleLength];

        return $"{incompleteNibble.PadToNibble()}{completeNibbles}";
    }

    public static string AddNibbleUnderscores(this string binaryString)
    {
        var cleanedString = binaryString.Replace(Constants.UnderScore, string.Empty);

        var stringBuilder = new StringBuilder();
        for (var i = cleanedString.Length - 1; i >= 0; i--)
        {
            var index = cleanedString.Length - 1 - i;
            stringBuilder.Insert(0, cleanedString[i]);

            if (index % 4 == 3 && index != 0 && i != 0)
                stringBuilder.Insert(0, Constants.UnderScore);
        }

        return stringBuilder.ToString();
    }

    public static string ToBinaryString(this int number)
        => Convert.ToString(number, 2);

    private static void ShiftIntoBcd(char charToAppend, StringBuilder bcdToShiftInto, StringBuilder? overflowBcd = null,
        StringBuilder? overflow2Bcd = null)
    {
        bcdToShiftInto.Append(charToAppend);
        CheckBcdForOverflow(bcdToShiftInto, overflowBcd);
        CheckBcdForOverflow(overflowBcd, overflow2Bcd);
    }

    private static void CheckBcdForOverflow(StringBuilder? bcdToShiftInto, StringBuilder? overflowBcd)
    {
        if (bcdToShiftInto is null || overflowBcd is null)
            return;

        if (bcdToShiftInto.Length != 5)
            return;

        overflowBcd.Append(bcdToShiftInto[0]);
        bcdToShiftInto.Remove(0, 1);
    }

    private static void CheckForGreaterThanFive(StringBuilder? bcd0, StringBuilder? bcd1 = null,
        StringBuilder? bcd2 = null)
    {
        bcd0.AddThreeIf(IsGreaterThanOrEqualToFive);
        bcd1.AddThreeIf(IsGreaterThanOrEqualToFive);
        bcd2.AddThreeIf(IsGreaterThanOrEqualToFive);
    }

    private static void AddThreeIf(this StringBuilder? bcd, Func<StringBuilder?, bool> condition)
    {
        if (!condition(bcd) || bcd is null)
            return;

        var bcdValue =
            bcd
                .ToString()
                .BinaryStringToInt()
                .Add(3)
                .ToBinaryString();

        bcd
            .Clear()
            .Append(bcdValue);
    }

    private static bool IsGreaterThanOrEqualToFive(StringBuilder? bcd)
    {
        if (bcd is null || bcd.Length == 0)
            return false;

        var bcdValue = Convert.ToInt32(bcd.ToString(), 2);
        return bcdValue.IsGreaterThanOrEqualTo(5);
    }

    private static int BinaryStringToInt(this string binaryString)
        => Convert.ToInt32(binaryString, 2);

    private static string PadToNibble(this string? bcd)
    {
        bcd ??= string.Empty;
        return bcd.PadLeft(4, '0');
    }
}