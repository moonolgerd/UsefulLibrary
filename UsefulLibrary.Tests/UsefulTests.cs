using System;
using UsefulLibrary;
using Xunit;

namespace UsefulLibrary.Tests
{
    public class UsefulTests
    {
        // --- Add(int, int) ---

        [Fact]
        public void Add_TwoPositiveIntegers_ReturnsSum()
        {
            var result = Useful.Add(2, 3);

            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_ZeroAndZero_ReturnsZero()
        {
            var result = Useful.Add(0, 0);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_ZeroAndPositive_ReturnsPositive()
        {
            var result = Useful.Add(0, 7);

            Assert.Equal(7, result);
        }

        [Fact]
        public void Add_ZeroAndNegative_ReturnsNegative()
        {
            var result = Useful.Add(0, -4);

            Assert.Equal(-4, result);
        }

        [Fact]
        public void Add_TwoNegativeIntegers_ReturnsNegativeSum()
        {
            var result = Useful.Add(-2, -3);

            Assert.Equal(-5, result);
        }

        [Fact]
        public void Add_PositiveAndNegative_ReturnsDifference()
        {
            var result = Useful.Add(10, -4);

            Assert.Equal(6, result);
        }

        [Fact]
        public void Add_IsCommutative()
        {
            Assert.Equal(Useful.Add(7, 9), Useful.Add(9, 7));
        }

        [Fact]
        public void Add_IntMaxValueAndZero_ReturnsIntMaxValue()
        {
            var result = Useful.Add(int.MaxValue, 0);

            Assert.Equal(int.MaxValue, result);
        }

        [Fact]
        public void Add_IntMinValueAndZero_ReturnsIntMinValue()
        {
            var result = Useful.Add(int.MinValue, 0);

            Assert.Equal(int.MinValue, result);
        }

        [Fact]
        public void Add_Overflow_WrapsAround()
        {
            // Standard unchecked int arithmetic wraps around.
            var result = Useful.Add(int.MaxValue, 1);

            Assert.Equal(int.MinValue, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(100, -100, 0)]
        [InlineData(42, 0, 42)]
        [InlineData(int.MaxValue, -1, int.MaxValue - 1)]
        public void Add_KnownValues_ReturnsExpectedSum(int a, int b, int expected)
        {
            var result = Useful.Add(a, b);

            Assert.Equal(expected, result);
        }
    }
}
