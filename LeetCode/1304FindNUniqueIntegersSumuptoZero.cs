namespace LeetCode;

/// <summary>
/// Given an integer n, return any array containing n unique integers such that they add up to 0.
/// </summary>
public class FindNUniqueIntegersSumuptoZero1304 {
    public int[] SumZero(int n) {
        if (n == 0)
        {
            return [0];
        }
        
        var offSet = n % 2 == 0 ? 0 : 1;
        var array1 = Enumerable.Range(1, ((n - offSet) + 1) / 2).ToArray();
        var array2 = Enumerable.Range(1, ((n - offSet) + 1) / 2).Select(x => -x).ToArray();
        return array1.Concat(array2).Concat(offSet == 1 ? [0] : []).ToArray();
    }
}