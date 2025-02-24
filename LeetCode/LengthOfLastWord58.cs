namespace LeetCode;

public class LengthOfLastWord58
{
    public static int LengthOfLastWord(string s) {
        var length = 0;
        var actualLength = 0;
        
        foreach (var @char in s)
        {
            var intChar = (int)@char;
            if ((intChar >= 65 && intChar <= 90) || (intChar >= 97 && intChar <= 122))
            {
                length += 1;
                actualLength = length;
            }
            else
            {
                length = 0;
            }
        }
        
        return actualLength;
    }
}