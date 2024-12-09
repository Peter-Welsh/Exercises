// https://leetcode.com/problems/reverse-words-in-a-string/description
namespace Exercises.Solutions.Array_or_String;

public class ReverseWordsInString
{
    /// <summary>
    /// Clean solution
    /// </summary>
    /// <remarks>Prefer this readable and maintainable implementation.</remarks>
    public string ReverseWords(string s)
    {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return string.Join(' ', words.Reverse());
    }

    /// <summary>
    /// Optimized solution
    /// </summary>
    public string ReverseWords_Ugly(string s)
    {
        throw new NotImplementedException();
    }
}