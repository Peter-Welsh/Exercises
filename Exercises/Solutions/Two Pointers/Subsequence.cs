// https://leetcode.com/problems/is-subsequence/description
namespace Exercises.Solutions.Two_Pointers;

public class Subsequence
{
    public bool IsSubsequence(string s, string t)
    {
        var i = 0;
        for (var j = 0; i < s.Length && j < t.Length; j++)
        {
            if (s[i] != t[j]) { continue; }
            i++;
        }
        return i == s.Length;
    }
}