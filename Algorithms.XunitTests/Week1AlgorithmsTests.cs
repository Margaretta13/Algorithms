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
      
    }
}
