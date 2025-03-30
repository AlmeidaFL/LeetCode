namespace LeetCode;

public class HIndex274
{
    public static int HIndex(int[] citations) 
    {
        return citations
            .OrderDescending()
            .Select((citation, index) => new { Citation = citation, Index = index + 1 })
            .TakeWhile(x => x.Citation >= x.Index)
            .Count();
    }
}