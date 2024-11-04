using UtilsCSharp;
using UtilsCSharp.Utils;

namespace UtilsCSharpTests.BinaryTesting;

public class BinaryTests
{
    [Test, TestOf("BCDToBinary")]
    [TestCaseSource(typeof(TestData), nameof(TestData.BCDToBinary))]
    public void BCDToBinary(int expected, string bcd)
    {
        var bcdArray = bcd.Split('_');

        var actual = 0;
        for (var i = 0; i < bcdArray.Length; i++)
        {
            var bcdNumber = bcdArray[i];
            var binaryNumber = Convert.ToInt32(bcdNumber, 2);
            binaryNumber *= (int) Math.Pow(10, bcdArray.Length - 1 - i);
            actual += binaryNumber;
        }

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("BinaryToBCD")]
    [TestCaseSource(typeof(TestData), nameof(TestData.BinaryToBCD))]
    public void BinaryToBCD(string expected, string binary)
    {
        var actual = binary.BinaryToBcd();
        Assert.That(actual, Is.EqualTo(expected));
    }
}