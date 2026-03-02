using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 5.5;
            double number2 = 3.2;
            double expectedResult = 8.7;
            // Act
            double actualResult = calculator.Add(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
        [TestMethod]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = -10;
            double number2 = -5;
            double expectedResult = -15;
            // Act
            double actualResult = calculator.Add(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 10;
            double number2 = -3;
            double expectedResult = 7;
            // Act
            double actualResult = calculator.Add(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Subtract_FirstGreaterThanSecond_ReturnsPositive()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 15;
            double number2 = 5;
            double expectedResult = 10;
            // Act
            double actualResult = calculator.Subtract(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Subtract_FirstLessThanSecond_ReturnsNegative()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 5;
            double number2 = 15;
            double expectedResult = -10;
            // Act
            double actualResult = calculator.Subtract(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Subtract_EqualNumbers_ReturnsZero()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 10;
            double number2 = 10;
            double expectedResult = 0;
            // Act
            double actualResult = calculator.Subtract(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Multiply_TwoPositiveNumbers_ReturnsPositive()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 4;
            double number2 = 3;
            double expectedResult = 12;
            // Act
            double actualResult = calculator.Multiply(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Multiply_PositiveAndNegative_ReturnsNegative()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 4;
            double number2 = -3;
            double expectedResult = -12;
            // Act
            double actualResult = calculator.Multiply(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Multiply_ByZero_ReturnsZero()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 5;
            double number2 = 0;
            double expectedResult = 0;
            // Act
            double actualResult = calculator.Multiply(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Multiply_TwoNegativeNumbers_ReturnsPositive()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = -4;
            double number2 = -3;
            double expectedResult = 12;
            // Act
            double actualResult = calculator.Multiply(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 10;
            double number2 = 2;
            double expectedResult = 5;
            // Act
            double actualResult = calculator.Divide(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Divide_WithDecimalResult_ReturnsCorrectValue()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 5;
            double number2 = 2;
            double expectedResult = 2.5;
            // Act
            double actualResult = calculator.Divide(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Divide_NegativeByPositive_ReturnsNegative()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = -10;
            double number2 = 2;
            double expectedResult = -5;
            // Act
            double actualResult = calculator.Divide(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 10;
            double number2 = 0;
            // Act
            calculator.Divide(number1, number2);
            // Assert - ожидается исключение через атрибут
        }
        [TestMethod]
        public void Divide_ZeroByNumber_ReturnsZero()
        {
            // Arrange
            var calculator = new Calculator();
            double number1 = 0;
            double number2 = 5;
            double expectedResult = 0;
            // Act
            double actualResult = calculator.Divide(number1, number2);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        // Тесты с DataRow (параметризованные тесты)
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 3, 5)]
        [DataRow(0, 0, 0)]
        [DataRow(-5, 5, 0)]
        public void Add_MultipleCases_ReturnsCorrectSum(int a, int b, int expected)
        {
            var calc = new Calculator();
            var result = calc.Add(a, b);
            Assert.AreEqual(expected, result);
        }
        [DataTestMethod]
        [DataRow(6, 2, 3)]
        [DataRow(10, 5, 2)]
        [DataRow(0, 5, 0)]
        public void Divide_MultipleCases_ReturnsCorrectQuotient(double a,
        double b, double expected)
        {
            var calc = new Calculator();
            var result = calc.Divide(a, b);
            Assert.AreEqual(expected, result);
        }

    }
}
