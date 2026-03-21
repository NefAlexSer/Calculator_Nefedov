using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorLibrary;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator Calc = new Calculator();

        [TestMethod]
        public void Add_TwoPositiveNumbers()
        {
            // Arrange
            double a = 5;
            double b = 3;
            double expected = 8;

            // Act
            double result = Calc.Calculate(a,b,"+");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_PositiveAndNegativeNumbers()
        {
            // Arrange
            double a = 5;
            double b = -3;
            double expected = 2;

            // Act
            double result = Calc.Calculate(a, b, "+");

            // Assert
            Assert.AreEqual(expected, result);
        }

        public void Subtract_TwoPositiveNumbers()
        {
            // Arrange
            double a = 10;
            double b = 4;
            double expected = 6;

            // Act
            double result = Calc.Calculate(a, b, "-");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Multiply_TwoPositiveNumbers()
        {
            // Arrange
            double a = 6;
            double b = 7;
            double expected = 42;

            // Act
            double result = Calc.Calculate(a, b, "*");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Multiply_PositiveAndNegativeNumbers()
        {
            // Arrange
            double a = 5;
            double b = -4;
            double expected = -20;

            // Act
            double result = Calc.Calculate(a, b, "*");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_TwoPositiveNumbers()
        {
            // Arrange
            double a = 15;
            double b = 3;
            double expected = 5;

            // Act
            double result = Calc.Calculate(a, b, "/");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZero()
        {
            // Arrange
            double a = 10;
            double b = 0;

            // Act
            Calc.Calculate(a, b, "/");
        }

        [TestMethod]
        public void Power_PositiveBaseAndExponent()
        {
            // Arrange
            double a = 2;
            double b = 3;
            double expected = 8;

            // Act
            double result = Calc.Calculate(a, b, "^");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Power_ZeroExponent()
        {
            // Arrange
            double a = 5;
            double b = 0;
            double expected = 1;

            // Act
            double result = Calc.Calculate(a, b, "^");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Power_NegativeExponent()
        {
            // Arrange
            double a = 2;
            double b = -2;
            double expected = 0.25;

            // Act
            double result = Calc.Calculate(a, b, "^");

            // Assert
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
