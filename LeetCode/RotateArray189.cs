namespace LeetCode;

public class RotateArray189
{
    public static void Rotate(int[] nums, int k)
    {
        if (nums.Length == 1)
        {
            return;
        }


        var modK = k % nums.Length;
        var indexRotation = modK;
        var temp = nums[0];
        for (var i = 0; i < nums.Length; i++)
        {
            (nums[indexRotation], temp) = (temp, nums[indexRotation]);
            indexRotation = (indexRotation + modK) % nums.Length;
        }
        

    }
}