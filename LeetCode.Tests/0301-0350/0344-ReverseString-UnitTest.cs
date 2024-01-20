using LeetCode.P0301_0349;

namespace LeetCode.Tests.Problems
{
    public class _0344_ReverseString_UnitTest
    {
        [Fact]
        public void ReverseString_Equals()
        {
            // arrange
            Solution0344 solution = new Solution0344();
            char[] input = ['h', 'e', 'l', 'l', 'o'];
            char[] expected = ['o', 'l', 'l', 'e', 'h'];

            // act
            var output = solution.reverseString(input);

            // assert
            Assert.Equal(expected, output);
        }
    }
}