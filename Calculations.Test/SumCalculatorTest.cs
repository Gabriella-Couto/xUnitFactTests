using System;
using Xunit;

namespace Calculations.Test
{
    [Collection("Calculation")]
    public class SumCalculatorTest
    {
        private readonly Calculator _calculator;

        public SumCalculatorTest(CalculatorFixture fixture)
        {
            _calculator = fixture.calculator;
        }

        [Fact]
        public void SumTwoIntsEqual()
        {
            int result = _calculator.Sum(3, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void SumTwoIntsNotEqual()
        {
            int result = _calculator.Sum(20, 2);
            Assert.NotEqual(18, result);
        }

        [Fact]
        public void SumTwoDoublesEqual()
        {
            double result = _calculator.SumDouble(3.5, 2.5);
            Assert.Equal(6, result);
        }

        [Fact]
        public void SumTwoDoublesNotEqual()
        {
            double result = _calculator.SumDouble(3.5, 2.5);
            Assert.NotEqual(5.5, result);
        }

    }
}
