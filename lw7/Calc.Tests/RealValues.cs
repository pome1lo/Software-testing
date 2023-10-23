namespace Calc.Tests
{
    public class RealValues
    {
        private Calc calc;

        [SetUp]
        public void Setup()
        {
            this.calc = new();
        }

        [Test]
        public void DevidedByRealValue()
        {
            var result = calc.Calculate(3.33, 1.11, "/");
            var expectedResult = Is.EqualTo(3);
            Assert.That(result, expectedResult);
        }

        [Test]
        public void AmountByRealValue()
        {
            var result = calc.Calculate(6.33, 6.00001, "+");
            var expectedResult = Is.EqualTo(12.33001);
            Assert.That(result, expectedResult); 
        }

        [Test]
        public void DifferenceByRealValue()
        { 
            var result = calc.Calculate(7.77, 1.11, "-");
            var expectedResult = Is.EqualTo(6.6599999999999993d);
            Assert.That(result, expectedResult); 
        }

        [Test]
        public void MultiplicationByRealValue()
        {
            var result = calc.Calculate(6.33, 6.00001, "*");
            var expectedResult = Is.EqualTo(37.9800633);
            Assert.That(result, expectedResult); 
        }
        
        [TestCase(-6.33, 6.33)]
        [TestCase(8.5959, 8.5959)]
        public void ModuleByRealValue(double value, double objectedResult)
        {
            var result = calc.Calculate(value, "|");
            var expectedResult = Is.EqualTo(objectedResult);
            Assert.That(result, expectedResult); 
        }
    }
}