namespace Calc.Tests;

public class BasicOperations
{
    private Calc calc;

    [SetUp]
    public void Setup()
    {
        this.calc = new();
    }

    [Test]
    public void AmountTest()
    {
        var result = calc.Calculate(1, 2, "+");
        var expectedResult = Is.EqualTo(3);
        Assert.That(result, expectedResult);
    }

    public void DifferenceTest()
    {
        var result = calc.Calculate(5, 2, "-");
        var expectedResult = Is.EqualTo(3);
        Assert.That(result, expectedResult);
    }

    [Test]
    public void MultiplicationTest()
    {
        var result = calc.Calculate(10, 2, "*");
        var expectedResult = Is.EqualTo(20);
        Assert.That(result, expectedResult);
    }

    [Test]
    public void DivisionTest()
    {
        var result = calc.Calculate(21, 7, "/");
        var expectedResult = Is.EqualTo(3);
        Assert.That(result, expectedResult);
    } 

    [TestCase(8, 8)]
    [TestCase(6, 6)]
    public void PositiveModuleTest(double value, double objectedResult)
    {
        var result = calc.Calculate(value, "|");
        var expectedResult = Is.EqualTo(objectedResult);
        Assert.That(result, expectedResult);
    }
}