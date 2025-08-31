namespace LeetCode;

/// <summary>
/// You are given an n x n square matrix of integers grid. Return the matrix such that:
/// The diagonals in the bottom-left triangle (including the middle diagonal) are sorted in non-increasing order.
/// The diagonals in the top-right triangle are sorted in non-decreasing order.
/// Input: grid = [[1,7,3],[9,8,2],[4,5,6]]
/// Output: [[8,2,3],[9,6,7],[4,5,1]]
/// </summary>
public class SortMatrixbyDiagonals3446 
{
    public int[][] SortMatrix(int[][] grid) 
    {
        GetDiagonals(ref grid);
        return grid;
    }
    
    private static void GetDiagonals(ref int[][] grid)
    {
        // Bottom left
        for (var row = 0; row < grid.Length; row++)
        {
            ChangeDiagonal(ref grid, row, 0, -1);
        }
        
        // Top right
        for (var column = 1; column < grid[0].Length; column++)
        {
            ChangeDiagonal(ref grid, 0, column, 1);
        }
    }

    private static void ChangeDiagonal(ref int[][] grid, int startRow, int startColumn, int sortOrder)
    {
        var numberOfColumns = grid[0].Length;
        var diagonal = new List<int>();
        var row = startRow;
        var column = startColumn;
        while (column < numberOfColumns && row < grid.Length)
        {
            var number = grid[row][column];
            diagonal.Add(number);
            row++;
            column++;
        }

        if (sortOrder > 0)
        {
            diagonal.Sort();
        }
        else
        {
            diagonal = diagonal.OrderDescending().ToList();
        }
        
        row = startRow;
        column = startColumn;
        var index = 0;
        while (column < numberOfColumns && row < grid.Length)
        {
            grid[row][column] = diagonal[index];
            row++;
            column++;
            index++;
        }
    }
}