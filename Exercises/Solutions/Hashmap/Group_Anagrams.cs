// https://leetcode.com/problems/group-anagrams/description
namespace Exercises.Solutions.Hashmap;

public class Group_Anagrams
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anagramGroups = new Dictionary<string, IList<string>>();
        foreach (var str in strs)
        {
            var groupKey = GetGroupKey(str);
            if (anagramGroups.TryGetValue(groupKey, out var group))
            {
                group.Add(str);
                continue;
            }
            anagramGroups[groupKey] = new List<string> { str };
        }
        return anagramGroups.Values.ToList();
    }

    private static string GetGroupKey(string s)
    {
        var chars = new char[26];
        foreach (var c in s)
        {
            chars[c - 'a']++;
        }
        return new string(chars);
    }
}