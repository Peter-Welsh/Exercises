// https://leetcode.com/problems/game-of-life/description
namespace Exercises.Solutions.Matrix;

public class Game_Of_Life
{
    private static readonly (int X, int Y)[] velocities =
    [
        (1,-1),
        (1,0),
        (1,1),
        (0,-1),
        (0,1),
        (-1,-1),
        (-1,0),
        (-1,1)
    ];
    
    public void GameOfLife(int[][] board)
    {
        var m = board.Length;
        var n = board[0].Length;
        for (var row = 0; row < m; row++)
        {
            for (var col = 0; col < n; col++)
            {
                var numLive = GetNumLive(board, row, col);
                if (board[row][col] == 0 && numLive == 3)
                {
                    board[row][col] = 3;
                }
                if (board[row][col] == 1 && numLive is < 2 or > 3)
                {
                    board[row][col] = 2;
                }
            }
        }
        for (var row = 0; row < m; row++)
        {
            for (var col = 0; col < n; col++)
            {
                board[row][col] %= 2;
            }
        }
    }

    private static int GetNumLive(int[][] board, int row, int col)
    {
        return velocities
            .Where(velocity =>
                velocity.X + row >= 0 &&
                velocity.X + row < board.Length &&
                velocity.Y + col >= 0 &&
                velocity.Y + col < board[0].Length)
            .Count(velocity =>
                board[velocity.X + row][velocity.Y + col] == 1 ||
                board[velocity.X + row][velocity.Y + col] == 2);
    }
}