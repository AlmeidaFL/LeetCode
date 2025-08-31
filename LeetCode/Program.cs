// See https://aka.ms/new-console-template for more information

using LeetCode;

int[][] grid = [[1,7,3],[9,8,2],[4,5,6]];
Console.WriteLine(new SortMatrixbyDiagonals3446().SortMatrix(grid));
PrintMatrix(grid);

static void PrintMatrix(int[][] matrix)
{
    for (int i = 0; i < matrix.Length; i++) // percorre as linhas
    {
        for (int j = 0; j < matrix[i].Length; j++) // percorre as colunas da linha atual
        {
            Console.Write(matrix[i][j] + "\t");
        }
        Console.WriteLine();
    }
}