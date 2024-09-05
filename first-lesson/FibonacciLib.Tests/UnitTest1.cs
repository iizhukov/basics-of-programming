using NUnit.Framework;
using NUnit.Framework.Legacy;
using first_lesson.FibonacciLib;

namespace FibonacciLib.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void NIsEqualTo0()
    {
        int[] excepted = [];
        var result = Fibonacci.Fib(0);

        CollectionAssert.AreEqual(excepted, result);
    }

    [Test]
    public void NIsEqualTo1()
    {
        int[] excepted = [0];
        var result = Fibonacci.Fib(1);

        CollectionAssert.AreEqual(excepted, result);
    }

    [Test]
    public void NIsEqualTo6()
    {
        int[] excepted = [0, 1, 1, 2, 3, 5];
        var result = Fibonacci.Fib(6);

        CollectionAssert.AreEqual(excepted, result);
    }

    [Test]
    public void NIsEqualTo10()
    {
        int[] excepted = [0, 1, 1, 2, 3, 5, 8, 13, 21, 34];
        var result = Fibonacci.Fib(10);

        CollectionAssert.AreEqual(excepted, result);
    }
}