using UtilsCSharp;

namespace UtilsCSharpTests.BitWiseLogicTests;

public class BitWiseLogicTests
{
    [Test, TestOf("Not")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Not))]
    public void Not(string expected, string binaryString)
    {
        var actual = binaryString.NOT();
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Or")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Or))]
    public void Or(string expected, string left, string right)
    {
        var actual = left.OR(right);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("Xor")]
    [TestCaseSource(typeof(TestData), nameof(TestData.Xor))]
    public void Xor(bool expected, bool left, bool right)
    {
        var actual = left.XOR(right);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, TestOf("XorChar")]
    [TestCaseSource(typeof(TestData), nameof(TestData.XorChar))]
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