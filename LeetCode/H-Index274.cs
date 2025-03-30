namespace LeetCode;

public class HIndex274
{
    public static int HIndex(int[] citations) 
    {
        var orderedCitations = citations.OrderByDescending(c => c).ToArray();
        var hIndex = 0;
        foreach (var item in orderedCitations)
        {
            if (item <= hIndex || item == 0)
            {
                break;
            }
            
            hIndex++;
        }
        
        return hIndex;
    }
}