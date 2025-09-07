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

        var array = new int[n];
        var index = 0;
        for (int i = 1; i <= n / 2; i++)
        {
            array[index++] = i;
            array[index++] = -i;
        }

        if (n % 2 != 0)
        {
            array[n-1] = 0;
        }

        return array;
    }
}