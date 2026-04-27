using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Multiply_ShouldReturnCorrectResult()
        {
            var calc = new Calculator();
            int result = calc.Multiply(2, 6);
            Assert.AreEqual(12, result);   
        }

        [TestMethod]
        public void Multiply_WithZero_ShouldReturnZero()
        {
            var calc = new Calculator();
            int result = calc.Multiply(5, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Multiply_WithNegativeNumbers_ShouldReturnNegative()
        {
            var calc = new Calculator();
            int result = calc.Multiply(-2, 3);
            Assert.AreEqual(-6, result);
        }
    }
}