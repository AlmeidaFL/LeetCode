namespace LeetCode;

public class VowelsGameInAString3227 {
    public bool DoesAliceWin(string s)
    {
        var numberOfVowels = s.Aggregate(0, (acc, ch) => acc + (IsVowel(ch) ? 1 : 0));
        return numberOfVowels != 0;
    }

    private static bool IsVowel(char @char)
    {
        return @char is 'a' or 'e' or 'i' or 'o' or 'u';
    }
}