using DataStructures;
using Xunit;

namespace DataStructuresTests
{
    public class Week1Tests
    {
        private Week1 _week1;

        public Week1Tests()
        {
            _week1 = new Week1();
        }

        [Theory]
        [InlineData("5", "4 -1 4 1 1", 3)]
        [InlineData("5", "-1 0 4 0 3", 4)]
        public void ComputeHeight_Gives_Height_Of_Tree(string numNodes, string parents, int expectedHeight)
        {
            int result = _week1.ComputeHeightWithoutUsingTree(numNodes, parents);

            Assert.Equal(expectedHeight, result);
        }








        [Theory]
        [InlineData("{}")]
        [InlineData("()[]")]
        [InlineData("{a()}")]
        [InlineData("abc{a(de)bla}hel[l]o")]
        public void IsBalanced_Returns_Success_If_No_Unmatched_Bracket(string input)
        {
            var result = _week1.IsBalanced(input);

            Assert.Equal("Success", result);
        }

        
        [Theory]
        [InlineData("]", "1")]
        [InlineData("]()", "1")]
        [InlineData("{]()", "2")]
        [InlineData("foo(bar[i)]}", "10")]
        [InlineData("{}([]", "3")]
        [InlineData("foo(bar[i({]}", "12")]

        public void IsBalanced_Returns_Position_Of_Unmatched_Bracket(string input, string expectedOutput)
        {
            var result = _week1.IsBalanced(input);

            Assert.Equal(expectedOutput, result);
        }

    }
}
