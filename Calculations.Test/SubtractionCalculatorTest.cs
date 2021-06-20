using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Test
{
    [Collection("Calculation")]
    public class SubtractionCalculatorTest
    {
        private readonly Calculator _calculator;

        public SubtractionCalculatorTest(CalculatorFixture fixture)
        {
            _calculator = fixture.calculator;
        }

        [Fact]
        public void SubtractTwoInts()
        {
            int result = _calculator.SubtractionInt(25, 8);
            Assert.Equal(17, result);
        }

        [Fact]
        public void SumTwoDoublesEqual()
        {
            double result = _calculator.SubtractionDouble(80.7, 28.3);
            Assert.Equal(52.4, result, 1);
        }
    }
}
