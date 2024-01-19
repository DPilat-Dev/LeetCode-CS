/*  392. Is Subsequence (https://leetcode.com/problems/is-subsequence/description/)
    Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

    A subsequence of a string is a new string that is formed from the original string 
    by deleting some (can be none) of the characters without disturbing the relative positions 
    of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

    Example 1:

    Input: s = "abc", t = "ahbgdc"
    Output: true

    Example 2:

    Input: s = "axc", t = "ahbgdc"
    Output: false
*/

namespace LeetCode.P0351_0400.S0392_Is_Subsequence
{
    public class Solution_0392
    {
        public bool IsSubsequence(string s, string t)
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