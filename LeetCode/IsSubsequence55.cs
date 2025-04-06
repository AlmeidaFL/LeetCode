namespace LeetCode;

public class IsSubsequence55
{
    public static bool IsSubsequence(string subsequence, string wholeSequence)
    {
        if (subsequence.Length == 0 && wholeSequence.Length == 0)
        {
            return true;
        }
        
        if (subsequence.Length == 0)
        {
            return true;
        }

        var subsequenceIndex = 0;
        foreach (var @char in wholeSequence)
        {
            if (@char == subsequence[subsequenceIndex])
            {
                subsequenceIndex++;
            }
            if (subsequenceIndex == subsequence.Length)
            {
                return true;
            }
        }
        
        return false;
    }
}