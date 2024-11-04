using System.Text;
using Microsoft.VisualBasic;

namespace UtilsCSharp;

public static class Binary
{
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

        var bcd2Value = PadNibble(bcd2.ToString());
        var bcd1Value = PadNibble(bcd1.ToString());
        var bcd0Value = PadNibble(bcd0.ToString());

        return $"{bcd2Value}_{bcd1Value}_{bcd0Value}";
    }

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
        if (IsGreaterThanOrEqualToFive(bcd0))
            AddThree(bcd0);

        if (IsGreaterThanOrEqualToFive(bcd1))
            AddThree(bcd1);

        if (IsGreaterThanOrEqualToFive(bcd2))
            AddThree(bcd2);
    }

    private static bool IsGreaterThanOrEqualToFive(StringBuilder? bcd)
    {
        if (bcd is null || bcd.Length == 0)
            return false;

        var bcdValue = Convert.ToInt32(bcd.ToString(), 2);
        return bcdValue.IsGreaterThanOrEqualTo(5);
    }

    private static void AddThree(StringBuilder? bcd)
    {
        if (bcd is null)
            return;

        var bcdValue = Convert.ToInt32(bcd.ToString(), 2);
        bcdValue += 3;

        bcd.Clear();
        bcd.Append(Convert.ToString(bcdValue, 2));
    }

    private static string PadNibble(string? bcd)
    {
        bcd ??= string.Empty;
        return bcd.PadLeft(4, '0');
    }
}