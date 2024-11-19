using System.Text;

namespace UtilsCSharp;

public static class BitWiseLogic
{
    public static string NOT(this string binaryString)
    {
        if (!binaryString.IsBinaryString())
            return string.Empty;

        var result = new StringBuilder();

        foreach (var c in binaryString)
            result.Append(c == '1' ? '0' : '1');

        return result.ToString();
    }

    public static string OR(this string left, string right)
    {
        if (!left.IsBinaryString() || !right.IsBinaryString())
            return string.Empty;

        if (left.Length < right.Length)
            left = left.PadLeft(right.Length, '0');

        if (right.Length < left.Length)
            right = right.PadLeft(left.Length, '0');

        var result = new StringBuilder();

        for (var i = 0; i < left.Length; i++)
            result.Append(left[i] == '1' || right[i] == '1' ? '1' : '0');

        return result.ToString();
    }

    public static bool XOR(this bool left, bool right)
        => (!left || !right) && (left || right);

    public static char XOR(this char left, char right)
        => (left == '1').XOR(right == '1') ? '1' : '0';

    public static string XOR(this string left, string right)
    {
        if (!left.IsBinaryString() || !right.IsBinaryString())
            return "";

        if (left.Length < right.Length)
            left = left.PadLeft(right.Length, '0');

        if (right.Length < left.Length)
            right = right.PadLeft(left.Length, '0');

        var result = new StringBuilder();

        for (var i = 0; i < left.Length; i++)
            result.Append(left[i].XOR(right[i]));

        return result.ToString();
    }

    private static bool IsBinaryString(this string binaryString)
        => binaryString.All(c => c == '0' || c == '1');
}