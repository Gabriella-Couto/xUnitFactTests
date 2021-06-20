using System;
using System.Collections.Generic;
using Xunit;

namespace Calculations.Test
{
    public class FibonacciTestFixture
    {
        public Fibonacci Fibonacci = new Fibonacci();
    }

    public class FibonacciTest : IClassFixture<FibonacciTestFixture>
    {
        private readonly Fibonacci _fibonacci;

        public FibonacciTest(FibonacciTestFixture fibonacciFixture)
        {
            _fibonacci = fibonacciFixture.Fibonacci;
        }

        [Fact]
        public void SequenceDoestNotContainZero()
        {
            Assert.All(_fibonacci.fibonacciSequence, number => Assert.NotEqual(0, number));
        }

        [Fact]
        public void SequenceContainOne()
        {
            Assert.Contains(1, _fibonacci.fibonacciSequence);
        }

        [Fact]
        public void SequenceDoesNotContainsTen()
        {
            Assert.DoesNotContain(10, _fibonacci.fibonacciSequence);
        }

        [Fact]
        public void CollectionsNotEqual()
        {
            List<int> collection = new List<int> { 2, 3, 5, 8, 13 };
            Assert.NotEqual(collection, _fibonacci.fibonacciSequence);
        }
    }
}
