namespace LeetCode;

public static class NumberOfEquivalentDominoPairs1128
{
    public static int NumEquivDominoPairs(int[][] dominoes) {
        var counts = new Dictionary<(int, int), int>();
        int totalPairs = 0;

        foreach (var domino in dominoes)
        {
            var key = (Math.Min(domino[0], domino[1]), Math.Max(domino[0], domino[1]));

            if (counts.TryGetValue(key, out int count))
            {
                totalPairs += count;
                counts[key] = count + 1;
            }
            else
            {
                counts[key] = 1;
            }
        }

        return totalPairs;
    }
}