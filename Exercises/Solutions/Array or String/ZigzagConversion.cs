// https://leetcode.com/problems/zigzag-conversion/description
using System.Text;

namespace Exercises.Solutions.Array_or_String;

public class ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1 || numRows >= s.Length) { return s; }
        var answer = new StringBuilder();
        var skip = (numRows - 1) * 2;
        var cursor1 = 0;
        var row = 0;
        while (answer.Length < s.Length)
        {
            answer.Append(s[cursor1]);
            if (0 < row && row < numRows - 1)
            {
                var cursor2 = cursor1 + (skip - 2 * row);
                if (cursor2 < s.Length)
                {
                    answer.Append(s[cursor2]);
                }
            }
            cursor1 += skip;
            if (cursor1 < s.Length) { continue; }
            row++;
            cursor1 = row;
        }
        return answer.ToString();
    }
}