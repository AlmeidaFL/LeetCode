namespace LeetCode;

public class N_RepeatedElementinSize2NArray961 {
    public int RepeatedNTimes(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            if (i + 1 < nums.Length && nums[i] == nums[i + 1]
                || i + 2 < nums.Length && nums[i] == nums[i + 2]
                || i + 3 < nums.Length && nums[i] == nums[i + 3])
            {
                return nums[i];
            }
        }

        throw new Exception("It should not reach here");
    }
}