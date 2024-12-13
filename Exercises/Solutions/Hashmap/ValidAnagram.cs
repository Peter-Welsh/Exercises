// https://leetcode.com/problems/valid-anagram/description
namespace Exercises.Solutions.Hashmap;

public class ValidAnagram
{
    /// <summary>
    /// Fast solution - O(n)
    /// </summary>
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) { return false; }
        var letters = new char[26];
        for (var i = 0; i < s.Length; i++)
        {
            letters[s[i] - 'a']++;
            letters[t[i] - 'a']--;
        }
        return letters.All(letter => letter == 0);
    }
    
    /// <summary>
    /// Slow solution - O(sort) 
    /// </summary>
    public bool IsAnagram_Slow(string s, string t)
    {
        var sArray = s.ToCharArray();
        var tArray = t.ToCharArray();
        Array.Sort(sArray);
        Array.Sort(tArray);
        return new string(sArray) == new string(tArray);
    }
}