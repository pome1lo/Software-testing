using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc.Tests
{
    [TestClass]
    public class RealValues
    {
        [TestMethod]
        public void DevidedByRealValue()
        {
            Assert.AreEqual(
                new Calc().Calculate(3.33, 1.11, "/"), 3
            );
        }

        [TestMethod]
        public void AmountByRealValue()
        {
            Assert.AreEqual(
                new Calc().Calculate(6.33, 6.00001, "+"), 12.33001
            );
        }

        [TestMethod]
        public void DifferenceByRealValue()
        {
            Assert.AreEqual(
                new Calc().Calculate(7.77, 1.11, "-"), 6.66
            );
        }

        [TestMethod]
        public void MultiplicationByRealValue()
        {
            Assert.AreEqual(
                new Calc().Calculate(6.33, 6.00001, "*"), 37.9800633
            );
        }

        [TestMethod]
        public void NegativeModuleByRealValue()
        {
            Assert.AreEqual(
                new Calc().Calculate(-6.33, "|"), 6.33
            );
        }

        [TestMethod]
        public void PositiveModuleByRealValue()
        {
            Assert.AreEqual(
                new Calc().Calculate(8.5959, "|"), 8.5959
            );
        }
    }
}
