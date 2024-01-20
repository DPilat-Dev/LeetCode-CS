/*977. Squares of a Sorted Array (https://leetcode.com/problems/squares-of-a-sorted-array/)
*
* Given an integer array nums sorted in non-decreasing order, 
* return an array of the squares of each number sorted in non-decreasing order.
*
* Example 1:
* Input: nums = [-4,-1,0,3,10]
* Output: [0,1,9,16,100]
* Explanation: After squaring, the array becomes [16,1,0,9,100].
* After sorting, it becomes [0,1,9,16,100].

* Example 2:
* Input: nums = [-7,-3,2,3,11]
* Output: [4,9,9,49,121]
*/

namespace LeetCode.P0951_1000
{
    public class Solution0977
    {
        public int[] sortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            int left = 0;
            int right = nums.Length - 1;
            int end = right;

            while (left <= right)
            {
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    result[end] = nums[left] * nums[left];
                    end--;
                    left++;
                }
                else
                {
                    result[end] = nums[right] * nums[right];
                    end--;
                    right--;
                }
            }

            return result;
        }
    }
}