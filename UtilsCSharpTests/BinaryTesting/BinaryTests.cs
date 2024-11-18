using UtilsCSharp;

namespace UtilsCSharpTests.BinaryTesting;

public class BinaryTests
{
    [Test, TestOf("BCDToBinary")]
    [TestCaseSource(typeof(TestData), nameof(TestData.BcdToBinary))]
    public void BcdToBinary(string expected, string bcd)
    {
        var actual = bcd.BcdToBinary();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("BinaryToBCD")]
    [TestCaseSource(typeof(TestData), nameof(TestData.BinaryToBcd))]
    public void BinaryToBcd(string expected, string binary)
    {
        var actual = binary.BinaryToBcd();
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("MaskBinaryString")]
    [TestCaseSource(typeof(TestData), nameof(TestData.MaskBinaryString))]
    public void MaskBinaryString(string expected, string binaryString)
    {
        var actual = binaryString.MaskBinaryString();
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("AddNibbleUnderscores")]
    [TestCaseSource(typeof(TestData), nameof(TestData.AddNibbleUnderscores))]
    public void AddNibbleUnderscores(string expected, string binaryString)
    {
        var actual = binaryString.AddNibbleUnderscores();
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("ToBinaryString")]
    [TestCaseSource(typeof(TestData), nameof(TestData.ToBinaryString))]
    public void ToBinaryString(string expected, int number)
    {
        var actual = number.ToBinaryString();
        Assert.That(actual, Is.EqualTo(expected));
    }
}