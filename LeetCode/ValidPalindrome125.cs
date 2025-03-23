using System.Text;

namespace LeetCode;

public class ValidPalindrome125
{
    public static bool IsPalindrome(string s)
    {
        var onlyValidCharString = new StringBuilder();

        foreach (var @char in s.Where(char.IsLetterOrDigit))
        {
            onlyValidCharString.Append(@char.ToString().ToLower());
        }

        var newString = onlyValidCharString.ToString();
        var startIndex = 0;
        var endIndex = newString.Length - 1;

        while (startIndex < endIndex)
        {
            if (newString[startIndex] != newString[endIndex])
            {
                return false;
            }
            startIndex++;
            endIndex--;
        }
        
        return true;
    }
}