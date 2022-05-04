namespace Leetcode.Solution.Algorithms;

// Write a function to find the longest common prefix string amongst an array of strings.
//
//     If there is no common prefix, return an empty string "".
//
//  
//
//     Example 1:
//
// Input: strs = ["flower","flow","flight"]
// Output: "fl"
// Example 2:
//
// Input: strs = ["dog","racecar","car"]
// Output: ""
// Explanation: There is no common prefix among the input strings.
//  
//
//     Constraints:
//
// 1 <= strs.length <= 200
// 0 <= strs[i].length <= 200
// strs[i] consists of only lower-case English letters.

public class LongestPrefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (!strs.Any())
        {
            return string.Empty;
        }
        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix, StringComparison.Ordinal) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (string.IsNullOrWhiteSpace(prefix))
                {
                    return string.Empty;
                }
            }
        }

        return prefix;
    }
}