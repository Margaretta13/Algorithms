using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Algorithms.XunitTests
{
    public class Week2AlgorithmsTests
    {
        private Week2Algorithms algorithms;
        public Week2AlgorithmsTests()
        {
            algorithms = new Week2Algorithms();
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(10, 55)]
        public void FindNthFibonacciNaive_Finds_Nth_Fibonacci(int input, int expectedOutput)
        {
            var result = algorithms.GetNthFibonacciNaive(input);
            Assert.Equal(expectedOutput, result);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(10, 55)]
        public void FindNthFibonacciEfficient_Finds_Nth_Fibonacci(int input, int expectedOutput)
        {
            var result = algorithms.GetNthFibonacciEfficiet(input);
            Assert.Equal(expectedOutput, result);
        }

        [Theory]
        [InlineData(45, 0)]
        [InlineData(32, 9)]
        public void LastDigitOfFibonacci_Gives_Last_Digit(int nthFibonacci, int lastDigit)
        {
            var result = algorithms.LastDigitOfFibonacci(nthFibonacci);
            Assert.Equal(lastDigit, result);
        }

        [Theory]
        [InlineData(9, 27, 9)]
        [InlineData(9, 15, 3)]
        [InlineData(30, 15, 15)]
        [InlineData(12346, 67892, 2)]
        [InlineData(28851538, 1183019, 17657)]
        [InlineData(3918848, 1653264, 61232)]
        public void GreatestCommonDivisorNaive_Gets_GCD(int firstNumber, int secondNumber, int expectedGcd)
        {
            var result = algorithms.GreatestCommonDivisorNaive(firstNumber, secondNumber);
            Assert.Equal(expectedGcd, result);
        }

        [Theory]
        [InlineData(27, 9, 9)]
        [InlineData(15, 9, 3)]
        [InlineData(30, 15, 15)]
        [InlineData(67892, 12346, 2)]
        [InlineData(28851538, 1183019, 17657)]
        [InlineData(3918848, 1653264, 61232)]
        public void GreatestCommonDivisorEfficient_Gets_GCD(int firstNumber, int secondNumber, int expectedGcd)
        {
            var result = algorithms.GreatestCommonDivisorNaive(firstNumber, secondNumber);
            Assert.Equal(expectedGcd, result);
        }

        [Theory]
        [InlineData(8, 6, 24)]
        [InlineData(120, 24, 120)]
        [InlineData(28851538, 1183019, 1933053046)]
        public void LeastCommonMultipleEfficient_Returns_LCM(int largerNumber, int smallerNumber, int expectedLcm)
        {
            var result = algorithms.LeastCommonMultipleEfficient(largerNumber, smallerNumber);
            Assert.Equal(expectedLcm, result);
        }

        [Theory]
        [InlineData("2015", 3, 1)]
        [InlineData("2015", 4, 1)]
        [InlineData("2015", 144, 1)]
        [InlineData("239", 1000, 161)]
        [InlineData("2816213588", 30524, 10249)]
        public void FibonacciModulo(string nthFibonacci, int mModulo, int expectedModulo)
        {
            long n = Convert.ToInt64(nthFibonacci);
            var result = algorithms.FibonacciModulo(n, mModulo);
            Assert.Equal(expectedModulo, result);
        }

    }
}
