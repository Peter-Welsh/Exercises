// https://leetcode.com/problems/rotate-image/description
namespace Exercises.Solutions.Matrix;

public class RotateImage
{
    public void Rotate(int[][] matrix)
    {
        var n = matrix.Length;
        for (var i = 0; i < n / 2; i++)
        {
            var y = n - i - 1;
            for (var j = i; j < y; j++)
            {
                var x = n - j - 1;
                var tmp = matrix[i][j];
                matrix[i][j] = matrix[x][i];
                matrix[x][i] = matrix[y][x];
                matrix[y][x] = matrix[j][y];
                matrix[j][y] = tmp;
            }
        }
    }
}