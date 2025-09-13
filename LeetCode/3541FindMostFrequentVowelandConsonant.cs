namespace LeetCode;

public class FindMostFrequentVowelandConsonant3541 {
    public int MaxFreqSum(string s)
    {
        var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        
        var countVowels = new Dictionary<char, int>();
        var countConsonants = new Dictionary<char, int>();

        foreach (var @char in s)
        {
            if (vowels.Contains(@char))
            {
                countVowels.TryGetValue(@char, out var countVowel);
                countVowels[@char] = countVowel + 1;
                continue;
            }
            
            countConsonants.TryGetValue(@char, out var countConsonant);
            countConsonants[@char] = countConsonant + 1;
        }
        
        var consonants = countConsonants.Count > 0 ? countConsonants.Values.Max() : 0;
        var vowelsC = countVowels.Count > 0 ? countVowels.Values.Max() : 0;
        return vowelsC + consonants;
    }
}