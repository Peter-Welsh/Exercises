// https://leetcode.com/problems/ransom-note/description
namespace Exercises.Solutions.Hashmap;

public class RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var lettersAvailable = GetLetterFrequencies(magazine);
        return ransomNote.All(letter => lettersAvailable[letter - 'a']-- != 0);
    }

    private static int[] GetLetterFrequencies(string str)
    {
        var counts = new int[26];
        foreach (var letter in str)
        {
            counts[letter - 'a']++;
        }
        return counts;
    }
}