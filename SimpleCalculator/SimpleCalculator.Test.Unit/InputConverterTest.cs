using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private  readonly  InputConverter _inputConverter = new InputConverter();
        [TestMethod]
        public void ConvertValidStringInputIntoDouble()
        {
            var inputNum = "10";
            var convertedNum = _inputConverter.ConvertToNumeric(inputNum);
            Assert.AreEqual(10,convertedNum);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FaildToConvertInvalidStringInputIntoDouble()
        {
            var inputNum = "*";
            var convertedNum = _inputConverter.ConvertToNumeric(inputNum);
           
        }
    }
}
