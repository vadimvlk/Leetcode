namespace Leetcode.Solution.Algorithms;

public class RomanToInteger
{
    //Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

    // Symbol       Value
    // I             1
    // V             5
    // X             10
    // L             50
    // C             100
    // D             500
    // M             1000

    public int RomanToInt(string s)
    {
        int result = 0;
        int prev = 0;
        int curr = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            switch (s[i])
            {
                case 'I':
                    curr = 1;
                    break;
                case 'V':
                    curr = 5;
                    break;
                case 'X':
                    curr = 10;
                    break;
                case 'L':
                    curr = 50;
                    break;
                case 'C':
                    curr = 100;
                    break;
                case 'D':
                    curr = 500;
                    break;
                case 'M':
                    curr = 1000;
                    break;
            }

            if (curr >= prev)
            {
                result += curr;
            }
            else
            {
                result -= curr;
            }

            prev = curr;
        }

        return result;
    }
}