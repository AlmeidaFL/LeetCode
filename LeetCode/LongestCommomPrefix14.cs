using System.Text;

namespace LeetCode;

public class LongestCommomPrefix14
{
    public static string LongestCommonPrefix(string[] strs) {
        var j = 0;
        var prefix = new StringBuilder(); 
        foreach(var prefixChar in strs[0])
        {
            var everyoneAgrees = true;
            foreach (var str in strs)
            {
                if (j >= str.Length)
                {
                    everyoneAgrees = false;
                    break;
                };
                if (prefixChar == str[j]) continue;
                everyoneAgrees = false;
                break;
            }

            if (!everyoneAgrees)
            {
                break;
            }
            prefix.Append(prefixChar);
            j++;
        }

        return prefix.ToString();
    }   
}