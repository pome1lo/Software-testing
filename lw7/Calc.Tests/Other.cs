using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Tests
{
    [TestClass]
    public class Other
    {
        [TestMethod]
        public void GetLastResultAfterOperation()
        {
            Calc calc = new Calc();
            var firstResult = calc.Calculate(3.33, 1.11, "/");
            var lastResult = calc.GetLastReuslt();
            Assert.AreEqual(
                firstResult, lastResult
            );
        }

        [TestMethod]
        public void GetLastResultBeforeOperation()
        {
            Calc calc = new Calc();
            var lastResult = calc.GetLastReuslt();
            Assert.AreEqual(
                0, lastResult
            );
        }
    }
}
