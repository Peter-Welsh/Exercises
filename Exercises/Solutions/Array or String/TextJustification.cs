// https://leetcode.com/problems/text-justification/description
using System.Text;

namespace Exercises.Solutions.Array_or_String;

public class TextJustification
{
    /// <summary>
    /// Solution 1
    /// </summary>
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        var n = words.Length;
        var justifiedText = new List<string>();
        for (int i = 0, j; i < n; i = j)
        {
            var len = -1;
            for (j = i; j < n && len + 1 + words[j].Length <= maxWidth; j++)
            {
                len += 1 + words[j].Length;
            }
            var numSpaces = 1;
            var extra = 0;
            if (j != i + 1 && j != n)
            {
                numSpaces = (maxWidth - len) / (j - 1 - i) + 1;
                extra = (maxWidth - len) % (j - 1 - i);
            }
            var row = new StringBuilder(words[i]);
            for (var k = i + 1; k < j; k++, extra--)
            {
                row.Append(new string(' ', numSpaces + (extra > 0 ? 1 : 0)));
                row.Append(words[k]);
            }
            row.Append(new string(' ', maxWidth - row.Length));
            justifiedText.Add(row.ToString());
        }
        return justifiedText;
    }

    /// <summary>
    /// Solution 2
    /// </summary>
    public List<string> FullJustify_2(string[] words, int maxWidth)
    {
        var result = new List<string>();
        var line = new StringBuilder();
        var start = 0;
        var length = 0;
        for (var i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= maxWidth - length)
            {
                length += words[i].Length + 1;
                continue;
            }
            var numWords = i - start - 1;
            var extraSpaceBetweenWords = 0;
            var remainingSpaces = maxWidth - length + 1;
            if (numWords > 0)
            {
                extraSpaceBetweenWords = remainingSpaces / numWords;
                remainingSpaces %= numWords;
            }
            while (start < i - 1)
            {
                line.Append(words[start]);
                line.Append(' ', extraSpaceBetweenWords + 1);
                start++;
                if (remainingSpaces <= 0) { continue; }
                line.Append(' ');
                remainingSpaces--;
            }
            line.Append(words[start]);
            line.Append(' ', remainingSpaces);
            result.Add(line.ToString());
            start = i;
            length = words[i].Length + 1;
            line.Clear();
        }
        line.Clear();
        while (start < words.Length - 1)
        {
            line.Append(words[start]);
            line.Append(' ');
            start++;
        }
        line.Append(words[start]);
        line.Append(' ', maxWidth - line.Length);
        result.Add(line.ToString());
        return result;
    }
}