namespace LeetCode;

/// <summary>
/// You are given a 2D binary array grid. Find a rectangle with horizontal and vertical sides with the smallest area, such that all the 1's in grid lie inside this rectangle.
/// Return the minimum possible area of the rectangle.
/// Input: grid = [[0,1,0],[1,0,1]]
/// Output: 6
/// </summary>
public class FindtheMinimumAreatoCoverAllOnesI3195 {
    public int MinimumArea(int[][] grid)
    {
        int columnA = int.MaxValue, rowA = int.MaxValue;
        int columnB = int.MinValue, rowB = int.MinValue;

        for (var row = 0; row < grid.Length; row++)
        {
            for (var column = 0; column < grid[row].Length; column++)
            {
                if (grid[row][column] != 1) continue;
                
                if (row < rowA)
                {
                    rowA = row;
                }
                
                if (column < columnA)
                {
                    columnA = column;
                }

                if (row > rowB)
                {
                    rowB = row;
                }
                
                if (column > columnB)
                {
                    columnB = column;
                }
            }
        }

        // Doesn't have 1
        if (rowA == int.MaxValue)
        {
            return 0;
        }
        
        var columnDelta = columnB - columnA + 1;
        var rowDelta = rowB - rowA + 1;
        
        return columnDelta * rowDelta;
    }
}