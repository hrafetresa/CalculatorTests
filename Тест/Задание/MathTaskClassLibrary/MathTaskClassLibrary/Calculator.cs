using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (Math.Abs(b) < double.Epsilon)
                throw new DivideByZeroException("Divisor cannot be zero");
            return a / b;
        }
        public double Power(double @base, double exponent)
        => Math.Pow(@base, exponent);
        public double SquareRoot(double number)
        {
            if (number < 0)
                throw new ArgumentException(
                "Cannot calculate square root of negative number",
                nameof(number));
            return Math.Sqrt(number);
        }
        public double Percentage(double value, double percent)
        => value * percent / 100;
        public void ClearMemory()
        {
            MemoryValue = 0;
        }
        public double MemoryValue { get; private set; }
        public void MemoryAdd(double value) => MemoryValue += value;
        public void MemorySubtract(double value) => MemoryValue -= value;
    }
}
