namespace LeetCode.Tests.Problems
{
    public class _0392_IsSubsequence_UnitTest
    {
        [Fact]
        public void IsSubsequence_True()
        {
            // arrange
            string s = "abc";
            string t = "ahbgdc";

            // act
            var result = _0392_IsSubsequence.IsSubsequence(s, t);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void IsSubsequence_False()
        {
            // arrange
            string s = "axc";
            string t = "ahbgdc";

            // act
            var result = _0392_IsSubsequence.IsSubsequence(s, t);

            // assert
            Assert.False(result);
        }
    }
}