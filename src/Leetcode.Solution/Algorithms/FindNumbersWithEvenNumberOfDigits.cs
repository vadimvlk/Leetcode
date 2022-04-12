namespace Leetcode.Solution.Algorithms;

public class FindNumbersWithEvenNumberOfDigits
{
    // Input: nums = [12,345,2,6,7896]
    // Output: 2
    // Explanation: 
    // 12 contains 2 digits (even number of digits). 
    //     345 contains 3 digits (odd number of digits). 
    //     2 contains 1 digit (odd number of digits). 
    //     6 contains 1 digit (odd number of digits). 
    //     7896 contains 4 digits (even number of digits). 
    // Therefore only 12 and 7896 contain an even number of digits.
    
    
    //Given an array nums of integers, return how many of them contain an even number of digits.
    public int FindNumbers(int[] nums)
    {
        int count = 0;
        foreach (int num in nums)
        {
            if (num.ToString().Length % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}