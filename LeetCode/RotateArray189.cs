using System.Runtime.InteropServices.JavaScript;

namespace LeetCode;

public class RotateArray189
{
    public static void Rotate(int[] nums, int k)
    {
        if (nums.Length == 1)
        {
            return;
        }

        var tempList = new int[nums.Length];
        
        var modK = k % nums.Length;
        var indexRotation = modK;
        foreach (var transferredNumber in nums)
        {
            tempList[indexRotation] = transferredNumber;
            indexRotation = (indexRotation + 1) % nums.Length;
        }
        
        Array.Copy(tempList, nums, nums.Length);
    }
    
    public static void RotateV2(int[] nums, int k)
    {
        if (nums.Length == 1)
        {
            return;
        }

        k %= nums.Length;
        Reverse(nums, 0, nums.Length-1);
        Reverse(nums, 0, k-1);
        Reverse(nums, k, nums.Length-1);
    }

    private static void Reverse(int[] numbs, int begin, int end)
    {
        while (begin < end)
        {
            (numbs[begin], numbs[end]) = (numbs[end], numbs[begin]);
            begin++;
            end--;
        }
    }
}