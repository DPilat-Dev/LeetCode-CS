namespace LeetCode.Tests.Problems
{
    public class _0392_IsSubsequence_UnitTest
    {
        [Fact]
        public void IsSubsequence_True()
        {
            // arrange
            _0392_IsSubsequence solution = new _0392_IsSubsequence();
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
            _0392_IsSubsequence solution = new _0392_IsSubsequence();
            string s = "axc";
            string t = "ahbgdc";

            // act
            var result = solution.IsSubsequence(s, t);

            // assert
            Assert.False(result);
        }
    }
}