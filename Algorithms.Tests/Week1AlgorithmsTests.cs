using NUnit.Framework;

namespace Algorithms.Tests
{
    [TestFixture]
    public class Week1AlgorithmsTests
    {
        [TestCase(5,3)]
        public void AddTwoNumbers_Adds_TwoNumbers(int a, int b)
        {
            var alg1 = new Week1Algorithms();
            int result = alg1.AddTwoNumbers(a, b);
            Assert.AreEqual(a+b, result);
        }
    }
}
