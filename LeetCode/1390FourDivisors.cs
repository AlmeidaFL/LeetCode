namespace LeetCode;

public class FourDivisors1390 {
    public int SumFourDivisors(int[] nums) {
        var divisors = new List<HashSet<int>>();
        
        foreach (var num in nums)
        {
            var sqrt = Math.Floor(Math.Sqrt(num));
            var newDivisors = new HashSet<int>();
            divisors.Add(newDivisors);
            for (var i = 1; i <= sqrt; i++)
            {
                if (num % i != 0) continue;
                newDivisors.Add(i);
                newDivisors.Add(num/i);
            }
        }

        return divisors.Where(l => l.Count == 4).Sum(l => l.Sum());
    }
}