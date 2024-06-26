﻿using System.Numerics;
using UtilsCSharp;

namespace UtilsCSharpTests.AlgorithmTesting;

public class AlgorithmsTests
{
    [SetUp]
    public void Setup()
    {
    }

    #region Cycle detection

    [Test, TestOf("GetLoopLength")]
    [TestCaseSource(typeof(TestData), nameof(TestData.GetLoopLength))]
    public void GetLoopLength<T>(T expected, List<T> list) where T : struct, INumber<T>
    {
        var actual = Algorithms.GetLoopLength(list);
        Assert.That(actual, Is.EqualTo(expected));
    }

    #endregion
}