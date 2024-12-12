// https://leetcode.com/problems/spiral-matrix/description
namespace Exercises.Solutions.Matrix;

public class SpiralMatrix
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> spiral = [];
        (int X, int Y)[] velocities = [(0, 1), (1, 0), (0, -1), (-1, 0)];
        int[] steps = [matrix[0].Length, matrix.Length - 1];
        int r = 0, c = -1, d = 0;
        var numElements = matrix.Length * matrix[0].Length;
        while (spiral.Count < numElements)
        {
            for (var i = 0; i < steps[d % 2]; i++)
            {
                r += velocities[d].X;
                c += velocities[d].Y;
                spiral.Add(matrix[r][c]);
            }
            steps[d % 2]--;
            d = (d + 1) % 4;
        }
        return spiral;
    }
}