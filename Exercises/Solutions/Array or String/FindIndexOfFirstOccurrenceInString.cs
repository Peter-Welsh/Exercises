// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description
namespace Exercises.Solutions.Array_or_String;

public class FindIndexOfFirstOccurrenceInString
{
    public int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle, StringComparison.Ordinal);
    }
}