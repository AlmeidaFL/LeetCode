using System.Text;

namespace LeetCode;

public class FindTheIndexOfTheFirstOccurrenceInAString28
{
    public static int StrStr(string haystack, string needle)
    {
        if (needle.Length > haystack.Length)
        {
            return -1;
        }

        var indexHaystack = 0;
        var indexNeedle = 0;
        var str = new StringBuilder();
        
        while (true)
        {
            if (str.ToString() == needle)
            {
                return indexHaystack - str.Length;
            }

            if (indexHaystack == haystack.Length)
            {
                break;
            }
            if (haystack[indexHaystack] == needle[indexNeedle])
            {
                str.Append(haystack[indexHaystack]);
                indexNeedle++;
            }
            else if (haystack[indexHaystack] != needle[indexNeedle])
            {
                if (str.Length > 0 && str[^1] == needle[0] && str[^1] != haystack[indexHaystack])
                {
                    indexHaystack--;
                    str.Clear();
                    indexNeedle = 0;
                    continue;
                }
                str.Clear();
                indexNeedle = 0;
                if (haystack[indexHaystack] == needle[indexNeedle])
                {
                    str.Append(haystack[indexHaystack]);
                    indexNeedle++;
                }
            }

            indexHaystack++;
        }
        
        return -1;
    }
}