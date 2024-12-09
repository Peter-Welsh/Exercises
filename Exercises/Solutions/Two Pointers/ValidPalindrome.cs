// https://leetcode.com/problems/valid-palindrome/description

namespace Exercises.Solutions.Two_Pointers;

public class ValidPalindrome
{
    /// <summary>
    /// Clean solution 
    /// </summary>
    /// <remarks>Prefer this readable and maintainable implementation.</remarks>
    public bool IsPalindrome(string s)
    {
        var normalized = s.ToLowerInvariant().Where(char.IsLetterOrDigit).ToArray();
        return normalized.SequenceEqual(normalized.Reverse());
    }
    
    /// <summary>
    /// Optimized solution 
    /// </summary>
    /// <remarks>Use this implementation only when every cycle counts.</remarks>
    public bool IsPalindrome_Ugly(string s)
    {
        var l = 0;
        var r = s.Length - 1;
        while (l <= r)
        {
            var leftChar = s[l];
            if (!char.IsLetterOrDigit(leftChar))
            {
                l++;
                continue;
            }
            var rightChar = s[r];
            if (!char.IsLetterOrDigit(rightChar))
            {
                r--;
                continue;
            }
            if (char.ToUpperInvariant(leftChar) != char.ToUpperInvariant(rightChar))
            {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}