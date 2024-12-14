// https://leetcode.com/problems/evaluate-reverse-polish-notation/description
namespace Exercises.Solutions.Stack;

public class EvaluateReversePolishNotation
{
    /// <remarks>
    /// int.Parse() is a significant source of slowdown.
    /// You can optimize this method by implementing a custom int parser.
    /// </remarks>
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        foreach (var token in tokens)
        {
            int result;
            switch (token)
            {
                case "+":
                    result = stack.Pop() + stack.Pop();
                    break;
                case "-":
                    var right = stack.Pop();
                    var left = stack.Pop();
                    result = left - right;
                    break;
                case "*":
                    result = stack.Pop() * stack.Pop();
                    break;
                case "/":
                    var divisor = stack.Pop();
                    var dividend = stack.Pop();
                    result = dividend / divisor;
                    break;
                default:
                    result = int.Parse(token);
                    break;
            }
            stack.Push(result);
        }
        return stack.Pop();
    }
}