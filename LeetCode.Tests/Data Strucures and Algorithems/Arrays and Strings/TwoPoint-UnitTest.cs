
using LeetCode.DataStucturesAndAlgorithems.ArraysAndStrings;

namespace LeetCode.Tests.DataStructuresAndAlgorithems
{
    public class TwoPointer_UnitTest
    {

        [Fact]
        public void Example1_True()
        {
            // arrange
            string test = "racecar";

            // act
            var result = TwoPointer.Example1(test);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void Example1_False()
        {
            // arrange
            string test = "aaba";

            // act
            var result = TwoPointer.Example1(test);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void Example2_True()
        {
            // arrange
            int target = 13;
            int[] nums = [1, 2, 4, 6, 8, 9, 14, 15];

            // act
            var result = TwoPointer.Example2(nums, target);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void Example2_False()
        {
            // arrange
            int target = 17;
            int[] nums = [1, 2, 4, 6, 8, 9, 14, 15];

            // act
            var result = TwoPointer.Example2(nums, target);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void Example3_True()
        {
            // arrange
            int[] arr1 = [1, 2, 5, 7, 9];
            int[] arr2 = [3, 4, 6, 8];
            List<int> expected = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            // act
            var actual = TwoPointer.Example3(arr1, arr2);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Example4_True()
        {
            // arrange
            string s = "ace";
            string t = "abcde";

            // act
            var result = TwoPointer.Example4(s, t);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void Example4_False()
        {
            // arrange
            string s = "tvc";
            string t = "cvbc";

            // act
            var result = TwoPointer.Example4(s, t);

            // assert
            Assert.False(result);
        }
    }
}