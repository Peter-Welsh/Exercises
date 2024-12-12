// https://leetcode.com/problems/set-matrix-zeroes/description
namespace Exercises.Solutions.Matrix;

public class SetMatrixZeroes
{
    public void SetZeroes(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var zeroRows = new bool[m];
        var zeroCols = new bool[n];
        for (var row = 0; row < m; row++)
        {
            for (var col = 0; col < n; col++)
            {
                if (matrix[row][col] != 0) { continue; }
                zeroRows[row] = true;
                zeroCols[col] = true;
            }
        }
        for (var row = 0; row < m; row++)
        {
            for (var col = 0; col < n; col++)
            {
                if (!zeroRows[row] && !zeroCols[col]) { continue; }
                matrix[row][col] = 0;
            } 
        }
    }
}