namespace LeetCode;

public class SortVowelsInAString2785 {
    public string SortVowels(string s)
    {
        var numberOf = new NumberOf();
        foreach (var @char in s)
        {
            GetNumberOfVowels(@char, ref numberOf);
        }

        var result = s.ToCharArray();
        var numberOfVowels = numberOf.Total;
        for (var i = 0; i < s.Length; i++)
        {
            var @char = s[i];
            if (IsVowel(@char) && numberOfVowels > 0)
            {
                if (numberOf.A > 0)
                {
                    numberOf.A -= 1;
                    result[i]='A';
                }
                else if (numberOf.E > 0)
                {
                    numberOf.E -= 1;
                    result[i]='E';
                }
                else if (numberOf.I > 0)
                {
                    numberOf.I -= 1;
                    result[i]='I';
                }
                else if (numberOf.O > 0)
                {
                    numberOf.O -= 1;
                    result[i]='O';
                }
                else if (numberOf.U > 0)
                {
                    numberOf.U -= 1;
                    result[i]='U';
                }
                else if (numberOf.a > 0)
                {
                    numberOf.a -= 1;
                    result[i]='a';
                }
                else if (numberOf.e > 0)
                {
                    numberOf.e -= 1;
                    result[i]='e';
                }
                else if (numberOf.i > 0)
                {
                    numberOf.i -= 1;
                    result[i]='i';
                }
                else if (numberOf.o > 0)
                {
                    numberOf.o -= 1;
                    result[i]='o';
                }
                else if (numberOf.u > 0)
                {
                    numberOf.u -= 1;
                    result[i]='u';
                }
                
                continue;
            }
            
            result[i]= @char;
        }
        
        return new string(result);
    }
    
    private static void GetNumberOfVowels(char @char, ref NumberOf numberOf)
    {
        switch (@char)
        {
            case 'a': numberOf.a += 1; break;
            case 'e': numberOf.e += 1; break;
            case 'i': numberOf.i += 1; break;
            case 'o': numberOf.o += 1; break;
            case 'u': numberOf.u += 1; break;
            case 'A': numberOf.A += 1; break;
            case 'E': numberOf.E += 1; break;
            case 'I': numberOf.I += 1; break;
            case 'O': numberOf.O += 1; break;
            case 'U': numberOf.U += 1; break;
        }
    }

    private record struct NumberOf(int a, int e, int i, int o, int u, int A, int E, int I, int O, int U)
    {
        public int Total => A + E + I + O + U + a + e + i + o + u;
    };
    
        
    private static bool IsVowel(char @char)
    {
        return @char is 'a' or 'e' or 'i' or 'o' or 'u' or 'A' or 'E' or 'I' or 'O' or 'U';
    }
}