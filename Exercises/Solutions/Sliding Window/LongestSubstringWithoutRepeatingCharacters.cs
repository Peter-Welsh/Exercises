// https://leetcode.com/problems/longest-substring-without-repeating-characters/description
namespace Exercises.Solutions.Sliding_Window;

public class LongestSubstringWithoutRepeatingCharacters
{
    /// <summary>
    /// Optimized solution
    /// </summary>
    public int LengthOfLongestSubstring(string s)
    {
        var maxLength = 0;
        var chars = new int[128];
        for (int l = 0, r = 0; r < s.Length; r++)
        {
            l = Math.Max(chars[s[r]], l);
            chars[s[r]] = r + 1;
            maxLength = Math.Max(r - l + 1, maxLength);
        }
        return maxLength;
    }
    
    /// <summary>
    /// Intuitive solution
    /// </summary>
    public int LengthOfLongestSubstring_Intuitive(string s)
    {
        var l = 0;
        var r = 0;
        var maxLength = 0;
        var substring = new HashSet<char>();
        foreach (var c in s)
        {
            while (substring.Contains(c))
            {
                substring.Remove(s[l]);
                l++;
            }
            substring.Add(c);
            var length = r - l + 1;
            maxLength = Math.Max(length, maxLength);
            r++;
        }
        return maxLength;
    }
}