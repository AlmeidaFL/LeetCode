using System.Text;

namespace LeetCode;

public class ReverseWordsInAString151
{
    public static string ReverseWords(string s)
    {
        var reversedWord = new StringBuilder();
        var spaceAdded = false;

        for (var i = s.Length - 1; i > 0; i--)
        {
            var newString = new StringBuilder();

            var @char = s[i];
            if (@char != ' ')
            {
                reversedWord.Append(@char);
            }
            else if (@char == ' ' && !spaceAdded)
            {
                reversedWord.Append(@char);
                spaceAdded = true;
            }
        }
        
        return reversedWord.ToString().Trim();
    }
}