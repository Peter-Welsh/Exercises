// https://leetcode.com/problems/set-matrix-zeroes/description
namespace Exercises.Solutions.Matrix;

public class SetMatrixZeroes
{
    public void SetZeroes(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var row = new int[m];
        var col = new int[n];
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (matrix[i][j] != 0) { continue; }
                row[i] = 1;
                col[j] = 1;
            }
        }
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (row[i] != 1 && col[j] != 1) { continue; }
                matrix[i][j] = 0;
            } 
        }
    }
}