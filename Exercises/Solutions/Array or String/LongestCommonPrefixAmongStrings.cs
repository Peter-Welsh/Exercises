// https://leetcode.com/problems/longest-common-prefix/description
namespace Exercises.Solutions.Array_or_String;

public class LongestCommonPrefixAmongStrings
{
    public string LongestCommonPrefix(string[] strs)
    {
        var firstString = strs[0];
        int len;
        for (len = 0; len < firstString.Length; len++)
        {
            if (strs.Any(s => len >= s.Length || s[len] != firstString[len]))
            {
                break;
            }
        }
        return firstString[..len];
    }
}