namespace Leetcode.Solution.Algorithms;

// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
//
//     An input string is valid if:
//
// Open brackets must be closed by the same type of brackets.
//     Open brackets must be closed in the correct order.
//  
//
//     Example 1:
//
// Input: s = "()"
// Output: true
// Example 2:
//
// Input: s = "()[]{}"
// Output: true
// Example 3:
//
// Input: s = "(]"
// Output: false

public class ValidParentheses
{
    private Dictionary<char, char> _map = new Dictionary<char, char>()
    {
        {')', '('},
        {'}', '{'},
        {']', '['},
    };

    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length % 2 != 0)
        {
            return false;
        }

        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (_map.ContainsKey(c))
            {
                char top = stack.Count == 0 ? '#' : stack.Pop();
                if (top != _map[c])
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}