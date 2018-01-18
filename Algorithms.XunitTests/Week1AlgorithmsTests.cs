using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Algorithms.XunitTests
{
    public class Week1AlgorithmsTests
    {
        [Theory]
        [InlineData(3, 5)]
        [InlineData(1, 9)]
        [InlineData(9, 9)]
        public void AddTwoNumbers_Adds_TwoNumbers_xunit(int a, int b)
        {
            var alg1 = new Week1Algorithms();
            int result = alg1.AddTwoNumbers(a, b);
            Assert.Equal(a + b, result);
        }

        [Theory]
        [InlineData(new[]{2,5,1}, 10)]
        [InlineData(new[]{6,9,8,5}, 72)]
        [InlineData(new[]{1,2,18,7,1,14,9,0,12}, 252)]
        public void GetMaxProduct_Gets_MaxProduct(int[] array, int product)
        {
            var alg1 = new Week1Algorithms();
            int result = alg1.GetMaxProduct(array);
            Assert.Equal(product, result);
        }
      
    }
}
