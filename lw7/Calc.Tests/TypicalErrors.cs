using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calc.Tests
{
    [TestClass]
    public class TypicalErrors
    {
        [TestMethod]
        public void DevidedByZero()
        {
            Assert.ThrowsException<Exception>(
                () => new Calc().Calculate(10, 0, "/")
            );
        }

        [TestMethod]
        public void NegativeMultiplication()
        {
            Assert.AreEqual(
                new Calc().Calculate(-5, -5, "*"), 25
            );
        }

        [TestMethod]
        public void WithoutParameters_String()
        {
            Assert.ThrowsException<Exception>(
              () => new Calc().Calculate(0, 0, "error")
            );
        }

        [TestMethod]
        public void WithoutParameters_Char()
        {
            Assert.ThrowsException<Exception>(
              () => new Calc().Calculate(0, 0, "&")
            );
        }

        [TestMethod]
        public void WithoutParameters_Char_2arguments()
        {
            Assert.ThrowsException<Exception>(
              () => new Calc().Calculate(0, "&")
            );
        }
    }
}