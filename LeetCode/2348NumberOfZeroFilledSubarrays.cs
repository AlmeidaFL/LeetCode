namespace LeetCode;

/// <summary>
/// Given an integer array nums, return the number of subarrays filled with 0.
/// A subarray is a contiguous non-empty sequence of elements within an array.
/// </summary>
public class NumberOfZeroFilledSubarrays2348 {
    public long ZeroFilledSubarray(int[] nums)
    {
        long numberOfZeroFilledSubarrays = 0;
        long zeroCounter = 0;
        foreach (var num in nums)
        {
            if (num == 0)
            {
                zeroCounter++;
            }
            else if (zeroCounter > 0)
            {
                numberOfZeroFilledSubarrays += GaussFormula(zeroCounter);
                zeroCounter = 0;
            }
        }

        if (zeroCounter > 0)
        {
            numberOfZeroFilledSubarrays += GaussFormula(zeroCounter);
        }
        
        return numberOfZeroFilledSubarrays;
    }

    private static long GaussFormula(long n) =>
        n * (n + 1) / 2;
}