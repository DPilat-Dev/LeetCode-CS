using LeetCode.P0351_0400.S0392_Is_Subsequence;

namespace LeetCode.Tests.Problems
{
    public class _0392_IsSubsequence_UnitTest
    {
        [Fact]
        public void IsSubsequence_True()
        {
            // arrange
            Solution0392 solution = new Solution0392();
            string s = "abc";
            string t = "ahbgdc";

            // act
            var result = solution.IsSubsequence(s, t);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void IsSubsequence_False()
        {
            // arrange
            Solution0392 solution = new Solution0392();
            string s = "axc";
            string t = "ahbgdc";

            // act
            var result = solution.IsSubsequence(s, t);

            // assert
            Assert.False(result);
        }
    }
}