using LeetCode.P0951_1000;

namespace LeetCode.Tests.Problems
{
    public class _0977_SquaresOfSortedArray_UnitTest
    {
        [Fact]
        public void sortedSquares_Equal1()
        {
            // arrange
            Solution0977 solution = new Solution0977();
            int[] nums = [-4, -1, 0, 3, 10];

            // act
            int[] expected = [0, 1, 9, 16, 100];
            var output = solution.sortedSquares(nums);

            // assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void sortedSquares_Equal2()
        {
            // arrange
            Solution0977 solution = new Solution0977();
            int[] nums = [-7, -3, 2, 3, 11];

            // act
            int[] expected = [4, 9, 9, 49, 121];
            var output = solution.sortedSquares(nums);

            // assert
            Assert.Equal(expected, output);
        }
    }
}