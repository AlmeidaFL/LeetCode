namespace LeetCode;

public class JumpGame55
{
    
    /// <summary>
    /// You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.
    /// Return true if you can reach the last index, or false otherwise.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
     
    public static bool CanJump(int[] nums)
    {
        var max = 0;

        if (nums.Length == 1)
        {
            return true;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            max = Math.Max(max, i + nums[i]);
            if (max == nums.Length - 1)
            {
                return true;
            }
            if (max == i)
            {
                return false;
            }
        }
        
        return max >= nums.Length;
    }
}