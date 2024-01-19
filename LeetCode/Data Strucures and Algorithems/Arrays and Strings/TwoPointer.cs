namespace LeetCode.DataStucturesAndAlgorithems.ArraysAndStrings
{
    public class TwoPointer
    {

        /*====================================================
        * Example 1: 
        * Given a string s, return true if it is a palindrome,
        * false otherwise.
        *
        * A string is a palindrome if it reads the same forward
        * as backward. This means, after reversing it, it is 
        * still the same string.
        *
        * For example: "abcdcba", or "racecar"
        * 
        * Time Complexity: O(n)
        * Space Complexity: O(1)
        *====================================================*/
        public static bool Example1(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        /*====================================================
        * Example 2: 
        * Given a sorted array of unique integers and a target integer,
        * return true if there exists a pair of numbers that sum to target, 
        * false otherwise. This problem is similar to Two Sum. 
        * (In Two Sum, the input is not sorted).
        *
        * For example, 
        * given nums = [1, 2, 4, 6, 8, 9, 14, 15] and target = 13, 
        * return true because 4 + 9 = 13.
        * 
        * Time Complexity: O(n)
        * Space Complexity: O(1)
        *====================================================*/
        public static bool Example2(int[] sorted, int target)
        {
            int left = 0;
            int right = sorted.Length - 1;

            while (left < right)
            {
                int sum = sorted[left] + sorted[right];
                if (sum == target)
                {
                    return true;
                }

                if (sum > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return false;
        }

        /*====================================================
       * Example 3: 
       * Given two sorted integer arrays arr1 and arr2,
       * return a new array that combines both of them and is
       * also sorted
       *
       * For example, 
       * given arr1 = [1, 3, 4, 6] and arr2 = [2, 5, 7, 8], 
       * return list = [1, 2, 3, 4, 5, 6, 7, 8].
       * 
       * Time Complexity: O(n)
       * Space Complexity: O(1)
       *====================================================*/
        public static List<int> Example3(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();
            int i = 0;
            int j = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    result.Add(arr1[i]);
                    i++;
                }
                else
                {
                    result.Add(arr2[j]);
                    j++;
                }
            }

            while (i < arr1.Length)
            {
                result.Add(arr1[i]);
                i++;
            }

            while (j < arr2.Length)
            {
                result.Add(arr2[j]);
                j++;
            }

            return result;
        }

        /*====================================================
       * Example 4: 392.Is Subsequence.
       * Given two strings s and t, 
       * return true if s is a subsequence of t, or false otherwise.

       * A subsequence of a string is a sequence of characters 
       * that can be obtained by deleting some (or none) of the 
       * characters from the original string, while maintaining 
       * the relative order of the remaining characters. 
       *
       * For example, "ace" is a subsequence of "abcde" while "aec" is not.
       * 
       * Time Complexity: O(n)
       * Space Complexity: O(1)
       *====================================================*/
        public static bool Example4(string s, string t)
        {
            int i = 0;
            int j = 0;

            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                }
                j++;
            }

            return i == s.Length;
        }
    }
}