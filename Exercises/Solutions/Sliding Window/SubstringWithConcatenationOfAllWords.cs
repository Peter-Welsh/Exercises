// https://leetcode.com/problems/substring-with-concatenation-of-all-words/description
namespace Exercises.Solutions.Sliding_Window;

public class SubstringWithConcatenationOfAllWords
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        var wordLength = words[0].Length;
        var wordCount = words.Length;
        var wordMap = BuildWordMap(words);
        var indexes = new List<int>();
        for (var i = 0; i < wordLength; i++)
        {
            var left = i;
            var right = i;
            var count = 0;
            var cur = 0;
            var wordCounts = new Dictionary<string, int>(wordMap);
            while (right + wordLength <= s.Length)
            {
                var k = s.Substring(right, wordLength); 
                right += wordLength;
                if (wordCounts.ContainsKey(k) && --wordCounts[k] >= 0)
                {
                    cur++;
                }
                count++;
                if (count > wordCount)
                {
                    var removing = s.Substring(left, wordLength);
                    left += wordLength;
                    if (wordCounts.ContainsKey(removing) && ++wordCounts[removing] > 0)
                    {
                        cur--;
                    }
                }
                if (cur != wordCount) { continue; }
                indexes.Add(left);
            }
        }
        return indexes;
    }

    private static Dictionary<string, int> BuildWordMap(string[] words)
    {
        var wordMap = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (!wordMap.TryGetValue(word, out var count))
            {
                wordMap[word] = 1;
                continue;
            }
            wordMap[word] = count + 1;
        }
        return wordMap;
    }
}