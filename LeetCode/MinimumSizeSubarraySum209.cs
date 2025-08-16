namespace LeetCode;

public class MinimumSizeSubarraySum209
{
    public static int MinSubArrayLen(int target, int[] nums)
    {
        var indexByAcc = nums
            .ToList()
            .OrderDescending()
            .Aggregate((Index: 0, Acc: 0), (current, num) =>
            {
                return current.Acc < target 
                    ? (current.Index + 1, current.Acc + num) 
                    : (current.Index, current.Acc);
            });
        return indexByAcc.Acc >= target ? indexByAcc.Index : 0;
    }
}