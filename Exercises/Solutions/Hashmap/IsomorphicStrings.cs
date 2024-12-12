// https://leetcode.com/problems/isomorphic-strings/description
namespace Exercises.Solutions.Hashmap;

public class IsomorphicStrings
{
    public bool IsIsomorphic(string s, string t)
    {
        var charMap1 = new int[256];
        var charMap2 = new int[256];
        for (var i = 0; i < s.Length; i++)
        {
            var char1 = s[i];
            var char2 = t[i];
            if (charMap1[char1] != charMap2[char2])
            {
                return false;
            }
            charMap1[char1] = i + 1;
            charMap2[char2] = i + 1;
        }
        return true;
    }
}