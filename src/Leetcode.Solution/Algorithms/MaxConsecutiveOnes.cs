namespace Leetcode.Solution.Algorithms;

public class MaxConsecutiveOnes
{
    //Given a binary array nums, return the maximum number of consecutive 1's in the array.
    
    // Input: nums = [1,1,0,1,1,1]
    // Output: 3
    // Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int value = 0;
        int maxValue = 0;
        foreach (int num in nums)
        {
            if (num == 1)
            {
                ++value;
            }
            else
            {
                maxValue = maxValue > value ? maxValue : value;
                value = 0;
            }
        }

        return maxValue > value ? maxValue : value;
    }
}