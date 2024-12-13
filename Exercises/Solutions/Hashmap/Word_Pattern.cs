// https://leetcode.com/problems/word-pattern/description
namespace Exercises.Solutions.Hashmap;

public class Word_Pattern
{
    public bool WordPattern(string pattern, string s)
    {
        var letterMap = new Dictionary<char, string>();
        var wordMap = new Dictionary<string, char>();
        var words = s.Split(' ');
        if (pattern.Length != words.Length)
        {
            return false;
        }
        for (var i = 0; i < words.Length; i++)
        {
            letterMap.TryAdd(pattern[i], words[i]);
            wordMap.TryAdd(words[i], pattern[i]);
            if (letterMap[pattern[i]] != words[i] || wordMap[words[i]] != pattern[i])
            {
                return false;
            }
        }
        return true;
    }
}