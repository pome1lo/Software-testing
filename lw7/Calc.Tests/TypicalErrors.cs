namespace Calc.Tests
{ 
    public class TypicalErrors
    {
        private Calc calc;

        [SetUp]
        public void Setup()
        {
            this.calc = new();
        }

        [Test]
        public void DevidedByZero()
        {
            Assert.Throws<Exception>(
                () => new Calc().Calculate(10, 0, "/")
            );
        }

        [Test]
        public void NegativeMultiplication()
        {
            var result = calc.Calculate(-5, -5, "*");
            var expectedResult = Is.EqualTo(25);
            Assert.That(result, expectedResult); 
        }

        [Test]
        public void WithoutParameters_String()
        {
            Assert.Throws<Exception>(
              () => new Calc().Calculate(0, 0, "error")
            );
        }

        [Test]
        public void WithoutParameters_Char()
        {
            Assert.Throws<Exception>(
                () => new Calc().Calculate(0, 0, "&")
            );
        }

        [Test]
        public void WithoutParameters_Char_2arguments()
        {
            Assert.Throws<Exception>(
              () => new Calc().Calculate(0, "&")
            );
        }
    }
}