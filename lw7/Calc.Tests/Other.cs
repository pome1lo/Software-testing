namespace Calc.Tests
{
    public class Other
    {
        private Calc calc;

        [SetUp]
        public void Setup()
        {
            this.calc = new();
        }

        [Test]
        public void GetLastResultAfterOperation()
        {
            var result = calc.Calculate(3.33, 1.11, "/");
            var expectedResult = Is.EqualTo(calc.GetLastReuslt());
            Assert.That(result, expectedResult); 
        }

        [Test]
        public void GetLastResultBeforeOperation()
        {
            var result = 0;
            var expectedResult = Is.EqualTo(calc.GetLastReuslt());
            Assert.That(result, expectedResult);
        }
    }
}