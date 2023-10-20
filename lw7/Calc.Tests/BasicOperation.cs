using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calc.Tests
{
    [TestClass]
    public class BasicOperation
    {
        [TestMethod]
        public void AmountTest()
        {
            Assert.AreEqual(new Calc().Calculate(1, 2, "+"), 3);
        }

        [TestMethod]
        public void DifferenceTest()
        {
            Assert.AreEqual(new Calc().Calculate(5, 2, "-"), 3);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            Assert.AreEqual(new Calc().Calculate(10, 2, "*"), 20);
        }

        [TestMethod]
        public void DivisionTest()
        {
            Assert.AreEqual(new Calc().Calculate(21, 7, "/"), 3);
        }

        [TestMethod]
        public void NegativeModuleTest()
        {
            Assert.AreEqual(
                new Calc().Calculate(-6, "|"), 6
            );
        }

        [TestMethod]
        public void PositiveModuleTest()
        {
            Assert.AreEqual(
                new Calc().Calculate(8, "|"), 8
            );
        }
    }
}