// https://leetcode.com/problems/valid-sudoku/description
namespace Exercises.Solutions.Matrix;

public class ValidSudoku
{
    /// <summary>
    /// Clean solution
    /// </summary>
    public bool IsValidSudoku(char[][] board)
    {
        var seen = new HashSet<string>();
        for (var r = 0; r < 9; r++)
        {
            for (var c = 0; c < 9; c++)
            {
                if (board[r][c] == '.') { continue; }
                var b = $"({board[r][c]})";
                if (!seen.Add(b + r + " in row") || 
                    !seen.Add(b + c + " in column") || 
                    !seen.Add(b + r / 3 + "-" + c / 3 + " in box"))
                {
                    return false;
                }
            }
        }
        return true;
    }
    
    /// <summary>
    /// More optimized
    /// </summary>
    /// <remarks>Avoids the overhead that comes with instantiating strings</remarks>
    public bool IsValidSudoku_Ugly(char[][] board)
    {
        var rows = new int[9, 9];
        var cols = new int[9, 9];
        var boxes = new int[3, 3, 9];
        for (var r = 0; r < 9; r++)
        {
            for (var c = 0; c < 9; c++)
            {
                if (board[r][c] == '.') { continue; }
                var number = board[r][c] - '1';
                if (rows[r, number]++ > 0 ||
                    cols[c, number]++ > 0 ||
                    boxes[r / 3, c / 3, number]++ > 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
    
    /// <summary>
    /// Most optimized 
    /// </summary>
    /// <remarks>Employs bit manipulation for maximum performance</remarks>
    public bool IsValidSudoku_Ugliest(char[][] board)
    {
        var rows = new int[9];
        var columns = new int[9];
        var boxes = new int[9];
        for (var i = 0; i < 9; i++)
        {
            for (var j = 0; j < 9; j++)
            {
                if (board[i][j] == '.') { continue; }
                var num = board[i][j] - '1';
                var mask = 1 << num;
                var boxIndex = i / 3 * 3 + j / 3;
                if ((rows[i] & mask) != 0 ||
                    (columns[j] & mask) != 0 ||
                    (boxes[boxIndex] & mask) != 0)
                {
                    return false;
                }
                rows[i] |= mask;
                columns[j] |= mask;
                boxes[boxIndex] |= mask;
            }
        }
        return true;
    }
}