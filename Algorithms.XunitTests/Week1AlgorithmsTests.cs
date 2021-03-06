﻿using Xunit;

namespace Algorithms.XunitTests
{
    public class Week1AlgorithmsTests
    {
        private Week1Algorithms algorithms;
        public Week1AlgorithmsTests()
        {
           algorithms = new Week1Algorithms(); 
        }

        [Theory]
        [InlineData(3, 5)]
        [InlineData(1, 9)]
        [InlineData(9, 9)]
        public void AddTwoNumbers_Adds_TwoNumbers_xunit(int a, int b)
        {
            int result = algorithms.AddTwoNumbers(a, b);
            Assert.Equal(a + b, result);
        }

        [Theory]
        [InlineData(new[]{2,5,1}, 10)]
        [InlineData(new[]{6,9,8,5}, 72)]
        [InlineData(new[]{1,2,18,7,1,14,9,0,12}, 252)]
        public void GetMaxProduct_Gets_MaxProduct(int[] array, int product)
        {
            int result = algorithms.GetMaxProduct(array);
            Assert.Equal(product, result);
        }
    }
}
