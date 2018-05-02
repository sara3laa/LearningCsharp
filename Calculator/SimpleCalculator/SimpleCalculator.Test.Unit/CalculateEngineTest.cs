using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculateEngineTest
    {
        private  readonly CalculateEngine _calculateEngine  = new CalculateEngine();
        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int num1 = 1;
            int num2 = 2;
            double result = _calculateEngine.Calculate("add", num1, num2);
            Assert.AreEqual(3,result);

        }
        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int num1 = 1;
            int num2 = 2;
            double result = _calculateEngine.Calculate("+", num1, num2);
            Assert.AreEqual(3, result);

        }
    }
}
