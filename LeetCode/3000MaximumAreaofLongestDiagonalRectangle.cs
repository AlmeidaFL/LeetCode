using static System.Math;
namespace LeetCode;

public class MaximumAreaofLongestDiagonalRectangle3000 {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        if (dimensions.Length == 0)
        {
            return 0;
        }

        var maxDiagonal = -1d;
        var maxArea = -1;
        foreach (var dimension in dimensions)
        {
            var diagonal = Sqrt(Pow(dimension[0],2) + Pow(dimension[1], 2));
            var area = dimension[0] * dimension[1];
            
            if (diagonal > maxDiagonal)
            {
                maxDiagonal = diagonal;
                maxArea = area;
            }
            else if (Math.Abs(diagonal - maxDiagonal) < 0.00001)
            {
                maxArea = Max(area, maxArea);
            }
        }

        return maxArea;        
    }
}