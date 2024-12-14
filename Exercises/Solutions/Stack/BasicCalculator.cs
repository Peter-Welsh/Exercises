// https://leetcode.com/problems/basic-calculator/description
namespace Exercises.Solutions.Stack;

public class BasicCalculator
{
    public int Calculate(string s)
    {
        var stack = new Stack<int>();
        var result = 0;
        var number = 0;
        var sign = 1;
        foreach (var c in s)
        {
            if (char.IsDigit(c))
            {
                number = 10 * number + (c - '0');
                continue;
            }
            switch (c)
            {
                case '+':
                    result += sign * number;
                    number = 0;
                    sign = 1;
                    continue;
                case '-':
                    result += sign * number;
                    number = 0;
                    sign = -1;
                    continue;
                case '(':
                    stack.Push(result);
                    stack.Push(sign);
                    sign = 1;   
                    result = 0;
                    continue;
                case ')':
                    result += sign * number;
                    number = 0;
                    result *= stack.Pop();
                    result += stack.Pop();
                    break;
            }
        }
        return result + sign * number;
    }
}