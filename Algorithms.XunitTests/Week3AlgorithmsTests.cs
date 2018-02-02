using System;

using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Algorithms.XunitTests
{
    public class Week3AlgorithmsTests
    {
        private Week3Algorithms week3Algorithms;

        public Week3AlgorithmsTests()
        {
            week3Algorithms = new Week3Algorithms();
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(28, 6)]
        public void GetMinimumNumberOfCoins_Gets_MinimumNumberOfCoins(int inputValue, int expectedNumberOfCoins)
        {
            int result = week3Algorithms.GetMinimumNumberOfCoins(inputValue);

            Assert.Equal(expectedNumberOfCoins, result);
        }

        [Theory]
        [InlineData(new[] { "3, 50", "60 20", "100, 50", "120, 30" }, 180.0000)]
        public void GetMaximumValueOfLoot_Gets_MaximumValueOfLoot(string[] inputs, decimal expectedMaxValue)
        {

            decimal result = week3Algorithms.GetMaximumValueOfLoot(inputs);

            Assert.Equal(expectedMaxValue, result);
        }
    }
}
