// https://leetcode.com/problems/minimum-window-substring/description
namespace Exercises.Solutions.Sliding_Window;

public class MinimumWindowSubstring
{
    public string MinWindow(string s, string t)
    {
        var charsNeeded = new int[128];
        var numMissing = t.Length;
        foreach (var c in t)
        {
            charsNeeded[c]++;
        }
        var startIndex = -1;
        var minLength = int.MaxValue;
        for (int l = 0, r = 0; r < s.Length; r++)
        {
            var rightChar = s[r];
            charsNeeded[rightChar]--;
            if (charsNeeded[rightChar] >= 0)
            {
                numMissing--;
            }
            if (numMissing != 0) { continue; }
            do
            {
                var length = r - l + 1;
                if (length < minLength)
                {
                    startIndex = l;
                    minLength = length;
                }
                var leftChar = s[l];
                l++;
                charsNeeded[leftChar]++;
                if (charsNeeded[leftChar] > 0)
                {
                    numMissing++;
                }
            } while (numMissing == 0);
        }
        return startIndex == -1 ? string.Empty : s.Substring(startIndex, minLength);
    }
}