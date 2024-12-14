// https://leetcode.com/problems/valid-parentheses/description
namespace Exercises.Solutions.Stack;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        var parens = new Stack<char>();
        foreach (var paren in s)
        {
            if (IsOpener(paren))
            {
                parens.Push(paren);
                continue;
            }
            if (parens.Count == 0) { return false; }
            var prev = parens.Pop();
            if (ParensMatch(prev, paren)) { continue; }
            return false;
        }
        return parens.Count == 0;
    }

    private static bool IsOpener(char paren) => paren is '(' or '[' or '{';

    private static bool ParensMatch(char paren1, char paren2) =>
        (paren1 == '(' && paren2 == ')') ||
        (paren1 == '[' && paren2 == ']') ||
        (paren1 == '{' && paren2 == '}');
}