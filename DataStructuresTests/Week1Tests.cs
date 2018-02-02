using DataStructures;
using Xunit;

namespace DataStructuresTests
{
    public class Week1Tests
    {
        [Theory]
        [InlineData("{}")]
        [InlineData("()[]")]
        [InlineData("{a()}")]
        [InlineData("abc{a(de)bla}hello")]
        public void IsBalanced_Returns_Success_If_No_Unmatched_Bracket(string input)
        {
            Week1 week1 = new Week1();

            var result = week1.IsBalanced(input);

            Assert.Equal("Success", result);
        }

        [Theory]
        [InlineData("]", "1")]
        [InlineData("]()", "1")]
        [InlineData("{]()", "2")]
        [InlineData("foo(bar[i)]}", "10")]
        [InlineData("{}([]", "3")]
        public void IsBalanced_Returns_Position_Of_Unmatched_Bracket(string input, string expectedOutput)
        {
            Week1 week1 = new Week1();

            var result = week1.IsBalanced(input);

            Assert.Equal(expectedOutput, result);
        }
        
    }
}
