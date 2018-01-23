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
    }
}
