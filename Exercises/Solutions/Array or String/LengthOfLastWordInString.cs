// https://leetcode.com/problems/length-of-last-word/description
namespace Exercises.Solutions.Array_or_String;

public class LengthOfLastWordInString
{
    /// <summary>
    /// Clean solution 
    /// </summary>
    /// <remarks>Prefer this readable and maintainable implementation.</remarks>
    public int LengthOfLastWord(string s)
    {
        s = s.Trim();
        var idx = s.LastIndexOf(' ');
        return s.Length - idx - 1;
    }
    
    /// <summary>
    /// Optimized solution
    /// </summary>
    /// <remarks>Use this implementation only when every cycle counts.</remarks>
    public int LengthOfLastWord_Ugly(string s)
    {
        var wordLength = 0;
        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                wordLength++;
                continue;
            }
            if (wordLength > 0) { break; }
        }
        return wordLength;
    }
}