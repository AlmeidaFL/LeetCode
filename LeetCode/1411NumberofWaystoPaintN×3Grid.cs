namespace LeetCode;

public class NumberofWaystoPaintN_3Grid1411
{
    private ColorPattern[] patterns =
    [
        // Pattern A B A
        new(Color.Red, Color.Green, Color.Red),
        new(Color.Red, Color.Yellow, Color.Red),
        new(Color.Green, Color.Red, Color.Green),
        new(Color.Green, Color.Yellow, Color.Green),
        new(Color.Yellow, Color.Red, Color.Yellow),
        new(Color.Yellow, Color.Green, Color.Yellow),

        // Pattern A B C
        new(Color.Yellow, Color.Red, Color.Green),
        new(Color.Yellow, Color.Green, Color.Red),
        new(Color.Green, Color.Yellow, Color.Red),
        new(Color.Green, Color.Red, Color.Yellow),
        new(Color.Red, Color.Yellow, Color.Green),
        new(Color.Red, Color.Green, Color.Yellow),
    ];
        
    public int NumOfWays(int n)
    {
        Dictionary<(int Row, ColorPattern ColorPattern), int> numberOfPatternsByRowAndColor = GetInitialSetup();
        Dictionary<ColorPattern, ColorPattern[]> compatiblePatternsByPattern = GetCompabilityDictionary();
        
        for (var row = 1; row <= n; row++)
        {
            foreach (var pattern in patterns)
            {
                var compatiblePatterns = compatiblePatternsByPattern[pattern];
                var subTotal = compatiblePatterns
                    .Aggregate(0, (current, cp) => (current + numberOfPatternsByRowAndColor[(row, cp)]) % ((int)Math.Pow(10, 9) + 7));
                numberOfPatternsByRowAndColor[(row + 1, pattern)] = subTotal;
            }
        }
        
        return patterns
            .Aggregate(0, (current, cp) => (current + numberOfPatternsByRowAndColor[(n, cp)]) % ((int)Math.Pow(10, 9) + 7));
    }

    private Dictionary<(int Row, ColorPattern Pattern), int> GetInitialSetup()
    {
        return patterns
            .Select(pattern => ((1, pattern), 1))
            .ToDictionary(x => x.Item1, x => x.Item2);
    }

    private Dictionary<ColorPattern, ColorPattern[]> GetCompabilityDictionary()
    {
        return patterns
            .Select(pattern => (pattern, patterns))
            .ToDictionary(
                x => x.Item1, 
                x => x.Item2.Where(y => IsCompatible(x.Item1, y)).ToArray());
    }

    private bool IsCompatible(ColorPattern A, ColorPattern B)
    {
        return A.A != B.A && A.B != B.B && A.C != B.C;
    }
    
    record struct ColorPattern(Color A, Color B, Color C);

    enum Color
    {
        Red,
        Yellow,
        Green,
    }
}