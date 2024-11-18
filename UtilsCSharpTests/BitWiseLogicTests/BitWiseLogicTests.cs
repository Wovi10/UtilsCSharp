using UtilsCSharp;

namespace UtilsCSharpTests.BitWiseLogicTests;

public class BitWiseLogicTests
{
    [Test, TestOf("NOT")]
    [TestCaseSource(typeof(TestData), nameof(TestData.NOT))]
    public void Not(string expected, string binaryString)
    {
        var actual = binaryString.NOT();
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("XOR")]
    [TestCaseSource(typeof(TestData), nameof(TestData.XOR))]
    public void XOR(bool expected, bool left, bool right)
    {
        var actual = left.XOR(right);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("XORChar")]
    [TestCaseSource(typeof(TestData), nameof(TestData.XORChar))]
    public void XorChar(char expected, char left, char right)
    {
        var actual = left.XOR(right);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("XorString")]
    [TestCaseSource(typeof(TestData), nameof(TestData.XorString))]
    public void XorString(string expected, string left, string right)
    {
        var actual = left.XOR(right);
        Assert.That(actual, Is.EqualTo(expected));
    }
}