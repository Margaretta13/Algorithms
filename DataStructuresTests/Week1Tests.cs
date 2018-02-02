using DataStructures;
using Xunit;

namespace DataStructuresTests
{
    public class Week1Tests
    {
        [Theory]
        [InlineData("()")]
        [InlineData("{}")]
        [InlineData("[]")]
        [InlineData("()[]")]
        [InlineData("{()}")]
        [InlineData("{a()}")]
        [InlineData("abc{a(de)bla}hello")]
        public void IsBalanced_Returns_Success_If_No_Unmatched_Bracket(string input)
        {
            Week1 week1 = new Week1();

            var result = week1.IsBalanced(input);

            Assert.Equal("Success", result);
        }

        [Theory]
        [InlineData("()")]
        [InlineData("{}")]
        [InlineData("[]")]
        [InlineData("()[]")]
        [InlineData("{()}")]
        [InlineData("{a()}")]
        [InlineData("abc{a(de)bla}hello")]
        public void IsBalanced_Returns_Position_Of_Unmatched_Bracket_Unmatched_Bracket(string input)
        {
            Week1 week1 = new Week1();

            var result = week1.IsBalanced(input);

            Assert.Equal("Success", result);
        }
        
    }
}
